using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using УИС.Components;

namespace УИС.Forms
{
    public partial class Working : ThemeForm
    {
        string[] tables, views;
        bool access;
        int img = 0, counter = 0;
        public Working(string usr, bool access)
        {
            InitializeComponent();
            this.access = access;
            Text = string.Format("пользователь: {0} | доступ: {1}", usr, access ? "запись" : "чтение");
            tables = DBControl.Tables;
            views = DBControl.Views;
            DBControl.Error+=new Action<string>(DBControl_Error);
            toolStripMenuItem7.ShortcutKeys = Keys.Escape | Keys.Control;
            TabFormControl.FormCreator = () => new ThemeForm() { ShowIcon = true };
        }
        static void DBControl_Error(string a) { MessageBox.Show(a); }
        #region DataTableView
        public DataTableView FindView(string name)
        {
            int ind = tabFormControl1.TabPages.IndexOfKey(name);
            if (ind != -1)
            {
                tabFormControl1.SelectedIndex = ind;
                return tabFormControl1.TabPages[ind].Controls[0] as DataTableView;
            }
            var q = OwnedForms.FirstOrDefault(f => f.Name == name);
            if (q != null)
            {
                q.Select();
                return q.Controls[0] as DataTableView;
            }
            return null;
        }
        public DataTableView AddView(string name, string sql)
        {
            if (sql == null) return null;
            var adapter = DBControl.Adapter(sql);
            var dtv = new DataTableView(name, adapter, access);
            tabFormControl1.AddTab(name, img, dtv);
            return dtv;
        }
        public DataTableView AddView(string name)
        {
            if (name == null) return null;
            return AddView(name, "select * from `" + name + "`");
        }
        public DataTableView FindOrAdd(string name)
        { return FindView(name) ?? AddView(name); }
        #endregion
        #region Menu
        private void HideList(object sender, EventArgs e)
        {
            toolStripMenuItem14.Text = (SCcontrols.Panel1Collapsed = !SCcontrols.Panel1Collapsed) ? ">" : "<";
        }
        private void Bupdate_Click(object sender, EventArgs e)
        {
            DBControl.FillViews();
            tables = DBControl.Tables;
            views = DBControl.Views;
            GC.Collect();
            Vlist.Items.Clear();
            if (img == 0)
                Vlist.Items.AddRange(tables);
            else Vlist.Items.AddRange(views);
        }
        private void ShowTables(object sender, EventArgs e)
        {
            Vlist.Items.Clear();
            Vlist.Items.AddRange(tables);
            img = 0;
        }
        private void ShowViews(object sender, EventArgs e)
        {
            Vlist.Items.Clear();
            Vlist.Items.AddRange(views);
            img = 1;
        }
        #endregion
        private void Change(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.Dock = (DockStyle.Bottom == p.Dock) ? DockStyle.Top : DockStyle.Bottom;
        }
        #region Open forms
        private void Badmin_Click(object sender, EventArgs e)
        {
            AdminSettings.ShowForm();
        }
        private void Bhelp_Click(object sender, EventArgs e)
        {
            Help.ShowForm();
        }
        private void Bprint_Click(object sender, EventArgs e)
        {
            Control tab = tabFormControl1.SelectedTab;
            if (tab == null) return;
            var view = tab.Controls[0] as DataTableView;
            Print.Show(view.HTML());
        }
        private void Btheme_Click(object sender, EventArgs e)
        {
            ThemeSelect.ShowForm();
        }
        private void Bexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        #endregion
        private void SelectView(object sender, EventArgs e)
        {
            FindOrAdd((sender as ComboBox).SelectedItem as string);
        }
        private void Vlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string sql = Vlist.Text, name = "expression" + ++counter;
                DataTableView dtv = FindView(sql);
                if (dtv != null) dtv.Exit();
                if (sql.StartsWith("#"))
                    dtv = new DataTableView(sql, DBControl.Schema(sql.Substring(1)));
                else
                    dtv = new DataTableView(sql, DBControl.Adapter(sql), access);
                if (dtv.IsDisposed) return;
                dtv.Disposed += dtv_Disposed;
                tabFormControl1.AddTab(sql, -1, dtv);
            }
        }
        private void dtv_Disposed(object sender, EventArgs e)
        {
            counter--;
        }
        #region StripMenu
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabFormControl1.SelectedTab.Dispose();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabFormControl1.TabPages.Clear();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var tab = tabFormControl1.SelectedTab;
            tabFormControl1.TabPages.Clear();
            tabFormControl1.TabPages.Add(tab);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var bnd = ActiveControl.Bounds;
            var bmp = new Bitmap(bnd.Width, bnd.Height);
            ActiveControl.DrawToBitmap(bmp, new Rectangle(new Point(), bnd.Size));
            Clipboard.SetImage(bmp);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Control tab = tabFormControl1.SelectedTab;
            if (tab == null) return;
            var view = tab.Controls[0] as DataTableView;
            new ExportForm(view.data, view.name).ShowDialog();
        }
        #endregion

        private void Working_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBControl.Error -= DBControl_Error;
        }
    }
}