using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using УИС.Forms;

namespace УИС.Components
{
    public partial class DataTableView : UserControl
    {
        public DbDataAdapter adapter;
        public DataTable table = new DataTable();
        public string name;
        int row, col;
        Working work;

        static bool IsNull(object obj)
        {
            return obj == null || obj is DBNull;
        }

        public DataTableView(string name)
        {
            this.name = name;
            InitializeComponent();
            data.DataSource = table;
        }
        public DataTableView(string name, DataTable Table) : this(name)
        {
            data.DataSource = table = Table;
            update.Visible = false;
        }
        public DataTableView(string name, DbDataAdapter Adapter, bool access = true) : this(name)
        {
            if (name.Contains("diagram")) diagram.Visible = true;
            adapter = Adapter;
            if (access && adapter.UpdateCommand != null)
                data.ReadOnly = !(save.Visible = data.AllowUserToAddRows = data.AllowUserToDeleteRows = true);
            UpdateData();
        }

        private void DataTableView_Load(object sender, EventArgs args)
        {
            Dock = DockStyle.Fill;
            work = FindForm() as Working;
            DataTable info = DBControl.Schema("Tables", new[] { null, null, name });
            if (info.Rows.Count == 0)
            {
                describe.Visible = false;
                return;
            }
            description.Text = info.Rows[0]["DESCRIPTION"] as string;
            foreach (DataGridViewColumn column in data.Columns)
            {
                var tool = new ToolStripMenuItem(column.HeaderText) { Checked = true, CheckOnClick = true };
                tool.CheckedChanged += SelectColumn;
                selector.Items.Add(tool);
                if (column is DataGridViewImageColumn) column.ContextMenuStrip = imageSelector;
            }
            foreach (DataRow row in DBControl.ForeignKeys.Select("FK_TABLE_NAME = '" + name + "'"))
            {
                var column = data.Columns[row["FK_COLUMN_NAME"].ToString()];
                var header = column.HeaderCell;
                var style = header.Style;
                style.Font = new Font(style.Font ?? Font, FontStyle.Underline);
                column.Tag = row["PK_TABLE_NAME"];
                header.Tag = row["PK_COLUMN_NAME"];
            }
            DataTable columns = DBControl.Schema("COLUMNS", new[] { null, null, name });
            foreach (DataRow row in columns.Rows)
            {
                var column = data.Columns[row["COLUMN_NAME"] as string];
                if ((bool)row["COLUMN_HASDEFAULT"])
                {
                    var def = row["COLUMN_DEFAULT"];
                    if (def is string) def = def.ToString().Trim('"');
                    if (column.ValueType == typeof(bool))
                        if (def.Equals("No")) def = false;
                        else if (def.Equals("Yes"))
                            def = true;
                    column.DefaultCellStyle.NullValue = def;
                }
                column.ToolTipText = row["DESCRIPTION"] as string;
            }
        }
        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Ошибка преобразования в " + (sender as DataGridView).Columns[e.ColumnIndex].ValueType.Name, "ошибка");
        }

        #region dataWork
        public void UpdateData()
        {
            table.Clear();
            try
            {
                if (adapter != null)
                    adapter.Fill(table);
            }
            catch (Exception E)
            {
                DBControl.LastError = E.Message;
                Dispose();
            }
            Psearch.Visible = false;
        }
        public void SaveData()
        {
            try
            {
                adapter.Update(table);
            }
            catch { }
        }
        public void Exit()
        {
            Parent.Dispose();
        }

        private void Update(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void Save(object sender, EventArgs e)
        {
            SaveData();
        }
        private void Exit(object sender, EventArgs e)
        {
            SaveData();
            Exit();
        }
        #endregion

        object eval(object value)
        {
            if (value == null || value is DBNull)
                return "&nbsp;";
            if (value is Image)
            {
                var img = value as Image;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                value = "<img src='data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray()) + "'/>";
            }
            return value;
        }
        public string HTML()
        {
            var sb = new StringBuilder("<html><head><meta charset='utf-8'><title>")
                   .Append(name)
                   .Append("</title>")
                   .Append(Theme.Current.GetStyle()).Append("</head><body><table cellspacing='0' border='1'><tr>");
            int columns = data.ColumnCount, rows = data.RowCount;
            if (data.AllowUserToAddRows) rows--;
            for (int i = 0; i < columns; i++)
                if (data.Columns[i].Visible)
                    sb.Append("<th>").Append(data.Columns[i].HeaderText).Append("</th>");
            sb.Append("</tr>");
            for (int i = 0; i < rows; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < columns; j++)
                    if (data.Columns[j].Visible)
                        sb.Append("<td>")
                            .Append(eval(data[j, i].FormattedValue))
                            .Append("</td>");
                sb.Append("</tr>");
            }
            return sb.Append("</table></body></html>").ToString();
        }
        public string Report(bool currentRow)
        {
            var sb = new StringBuilder("<html><head><meta charset='utf-8'><title>")
                   .Append(name)
                   .Append("</title>")
                   .Append(Theme.Current.GetStyle())
                   .Append("<style>th{text-align:left;}</style>")
                   .Append("</head><body>");
            int columns = data.ColumnCount, rows = data.RowCount;
            if (currentRow) ReportRow(sb, columns, row);
            else
                for (int i = 0; i < rows; i++)
                    if (data.Rows[i].Selected)
                        ReportRow(sb, columns, i);
            return sb.Append("</body></html>").ToString();
        }
        private void ReportRow(StringBuilder sb, int columns, int row)
        {
            sb.Append("<table cellspacing='0' border='1'>");
            for (int i = 0; i < columns; i++)
                if (data.Columns[i].Visible)
                    sb.Append("<tr><th>")
                        .Append(data.Columns[i].HeaderText)
                        .Append("</th><td>")
                        .Append(eval(data[i, row].FormattedValue))
                        .Append("</td></tr>");
            sb.Append("</table>");
        }

        #region Search
        public void Search(string Column, string Text, bool Case = false, bool Whole = false, bool Regex = false)
        {
            var c = data.Columns[Column];
            Search(c == null ? -1 : c.Index, Text, Case, Whole, Regex);
        }
        public void Search(int Column, string Text, bool Case = false, bool Whole = false, bool Regex = false)
        {
            if (!Regex) Text = System.Text.RegularExpressions.Regex.Escape(Text);
            if (Whole) Text = "^" + Text + "$";
            Regex regex;
            try
            {
                regex = new Regex(Text, Case ? RegexOptions.None : RegexOptions.IgnoreCase);
            }
            catch { return; }
            data.ClearSelection();
            if (Column == -1) Search(regex); else Search(Column, regex);
        }
        private void Search(Regex regex)
        {
            int rows = data.Rows.Count, columns = data.Columns.Count;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (regex.IsMatch((data[j, i].Value ?? "").ToString()))
                        data[j, i].Selected = true;
        }
        private void Search(int column, Regex regex)
        {
            int length = table.Rows.Count;
            for (int i = 0; i < length; i++)
                if (regex.IsMatch((data[column, i].Value ?? "").ToString()))
                    data.Rows[i].Selected = true;
        }
        private void Search(object sender, EventArgs e)
        {
            Search(columns.SelectedIndex, text.Text, p1.Checked, p2.Checked, p3.Checked);
        }
        private void OpenSearch(object sender, EventArgs e)
        {
            if (Psearch.Visible)
            {
                Psearch.Visible = false;
                var t = description.Padding;
                t.Right = 0;
                description.Padding = t;
                data.ClearSelection();
                return;
            }
            Psearch.Visible = true;
            var q = description.Padding;
            q.Right = Psearch.Width;
            description.Padding = q;
            columns.Items.Clear();
            foreach (DataGridViewColumn col in data.Columns)
                columns.Items.Add(col.HeaderText);
            text.Select();
        }
        private void Reset(object sender, EventArgs e)
        {
            p1.Checked = p2.Checked = p3.Checked = false;
            columns.SelectedIndex = -1;
            text.Text = "";
            data.ClearSelection();
        }
        #endregion

        private void data_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var col = data.Columns[e.ColumnIndex];
            var tag = col.Tag as string;
            if (tag != null) work.FindOrAdd(tag);
        }
        private void data_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            context.Items.Clear();
            col = e.ColumnIndex;
            row = e.RowIndex;
            context.Items.Add(_clearSelection);
            context.Items.Add(Separator);
            if (col == -1)
            {
                if (row == -1) { e.ContextMenuStrip = selector; return; }
                context.Items.Add(_deleteRow);
            }
            else if (row == -1)
            {
                context.Items.Add(_selectColumn);
                if (data.Columns[col].Tag != null)
                {
                    context.Items.Add(Separator);
                    context.Items.Add(_foreignTable);
                }
            }
            else
            {
                context.Items.Add(_setNull);
                if (data.Columns[col].Tag != null)
                {
                    context.Items.Add(Separator);
                    if (IsNull(data[col, row].Value))
                        context.Items.Add(_insertForeign);
                    else
                        context.Items.Add(_foreignKeys);
                }
                if (!data[col, row].Selected) data.CurrentCell = data[col, row];
                if (data.Columns[col] is DataGridViewImageColumn)
                {
                    context.Items.AddRange(new ToolStripItem[]
                    {
                        toolStripSeparator2,
                        toolStripMenuItem10
                    });
                }
            }
            if (e.ContextMenuStrip != null) context.Items.AddRange(e.ContextMenuStrip.Items);
            e.ContextMenuStrip = context;
        }

        private void AddRow()
        {
            data.CurrentCell = data[0, data.RowCount - 1];
        }

        #region ToolStrip
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.ClearSelection();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in data.SelectedCells)
                cell.Value = DBNull.Value;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            data.ClearSelection();
            for (int i = data.RowCount - 1; i >= 0; i--)
                data[col, i].Selected = true;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            work.FindOrAdd(data.Columns[col].Tag as string);
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var dtv = work.FindOrAdd(data.Columns[col].Tag as string);
            dtv.AddRow();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var table = data.Columns[col].Tag as string;
            var column = data.Columns[col].HeaderCell.Tag as string;
            var dtv = work.FindOrAdd(table);
            dtv.Search(column, data[col, row].Value.ToString(), Whole: true);
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var rows = data.SelectedRows;
            if (rows.Count == 0) data.Rows.RemoveAt(row);
            else
                foreach (DataGridViewRow r in rows)
                    data.Rows.Remove(r);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < selector.Items.Count; i++)
                (selector.Items[i] as ToolStripMenuItem).Checked = true;
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (ImageSelector.ShowForm(data[col, row].FormattedValue) == DialogResult.OK)
                data[col, row].Value = ImageSelector.Image;
        }
        private void close_selector(object sender, EventArgs e)
        {
            selector.Close();
        }
        private void SelectColumn(object sender, EventArgs e)
        {
            var me = sender as ToolStripMenuItem;
            data.Columns[me.Text].Visible = me.Checked;
        }
        #endregion

        private void describe_Click(object sender, EventArgs e)
        {
            var coont = data.Columns.Count;
            if (description.Visible = !description.Visible)
                while (coont-- > 0) if (!string.IsNullOrEmpty(data.Columns[coont].ToolTipText))
                        data.Columns[coont].HeaderText = data.Columns[coont].ToolTipText;
                    else { }
            else while (coont-- > 0) data.Columns[coont].HeaderText = table.Columns[coont].ColumnName;
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            Diagram.ShowForm(data);
        }

        private void _report_Click(object sender, EventArgs e)
        {
            row = data.CurrentRow.Index;
            Print.Show(Report(data.SelectedRows.Count == 0));
        }

        private void copy_Click(object sender, EventArgs e)
        {
            data.ClearSelection();
            Size s = Size.Empty;
            s.Height = 1 + (data.Rows.Count) * data.Rows[0].Height + data.ColumnHeadersHeight;
            s.Width = 1 + data.RowHeadersWidth;
            foreach (DataGridViewColumn col in data.Columns) s.Width += col.Width;
            var btm = new Bitmap(s.Width, s.Height);
            data.DrawToBitmap(btm, new Rectangle(new Point(0, 0), s));
            Clipboard.SetImage(btm);
        }
    }
}