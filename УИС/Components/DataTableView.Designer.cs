namespace УИС.Components
{
    partial class DataTableView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data = new System.Windows.Forms.DataGridView();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._clearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this._setNull = new System.Windows.Forms.ToolStripMenuItem();
            this._selectColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this._foreignTable = new System.Windows.Forms.ToolStripMenuItem();
            this._insertForeign = new System.Windows.Forms.ToolStripMenuItem();
            this._foreignKeys = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.description = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.describe = new System.Windows.Forms.ToolStripMenuItem();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.diagram = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.searchopen = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Psearch = new System.Windows.Forms.Panel();
            this.columns = new System.Windows.Forms.ComboBox();
            this.p3 = new System.Windows.Forms.CheckBox();
            this.Bsearch = new System.Windows.Forms.Button();
            this.Breset = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.CheckBox();
            this.p1 = new System.Windows.Forms.CheckBox();
            this.text = new System.Windows.Forms.TextBox();
            this.nullStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imageSelector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.context.SuspendLayout();
            this.menu.SuspendLayout();
            this.Psearch.SuspendLayout();
            this.selector.SuspendLayout();
            this.imageSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.DefaultCellStyle = dataGridViewCellStyle1;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(0, 42);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(300, 133);
            this.data.TabIndex = 1;
            this.data.Tag = 2;
            this.data.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.data_CellContextMenuStripNeeded);
            this.data.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_ColumnHeaderMouseDoubleClick);
            this.data.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clearSelection,
            this._setNull,
            this._selectColumn,
            this.Separator,
            this._foreignTable,
            this._insertForeign,
            this._foreignKeys,
            this._deleteRow});
            this.context.Name = "contextMenuStrip1";
            this.context.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.context.ShowImageMargin = false;
            this.context.Size = new System.Drawing.Size(255, 164);
            // 
            // _clearSelection
            // 
            this._clearSelection.Name = "_clearSelection";
            this._clearSelection.Size = new System.Drawing.Size(254, 22);
            this._clearSelection.Text = "убрать выделение";
            this._clearSelection.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // _setNull
            // 
            this._setNull.Name = "_setNull";
            this._setNull.Size = new System.Drawing.Size(254, 22);
            this._setNull.Text = "установить (null)";
            this._setNull.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // _selectColumn
            // 
            this._selectColumn.Name = "_selectColumn";
            this._selectColumn.Size = new System.Drawing.Size(254, 22);
            this._selectColumn.Text = "выделить столбец";
            this._selectColumn.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(251, 6);
            // 
            // _foreignTable
            // 
            this._foreignTable.Name = "_foreignTable";
            this._foreignTable.Size = new System.Drawing.Size(254, 22);
            this._foreignTable.Text = "перейти к связной таблице";
            this._foreignTable.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // _insertForeign
            // 
            this._insertForeign.Name = "_insertForeign";
            this._insertForeign.Size = new System.Drawing.Size(254, 22);
            this._insertForeign.Text = "внести данные во внешнюю таблицу";
            this._insertForeign.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // _foreignKeys
            // 
            this._foreignKeys.Name = "_foreignKeys";
            this._foreignKeys.Size = new System.Drawing.Size(254, 22);
            this._foreignKeys.Text = "показать внешние данные";
            this._foreignKeys.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // _deleteRow
            // 
            this._deleteRow.Name = "_deleteRow";
            this._deleteRow.Size = new System.Drawing.Size(254, 22);
            this._deleteRow.Text = "удалить строку";
            this._deleteRow.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // report
            // 
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(56, 24);
            this.report.Text = "сводка";
            this.report.Click += new System.EventHandler(this._report_Click);
            // 
            // description
            // 
            this.description.AutoEllipsis = true;
            this.description.Dock = System.Windows.Forms.DockStyle.Top;
            this.description.Location = new System.Drawing.Point(0, 24);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(300, 18);
            this.description.TabIndex = 2;
            this.description.Visible = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.describe,
            this.update,
            this.save,
            this.report,
            this.diagram,
            this.exit,
            this.searchopen,
            this.copy});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(300, 24);
            this.menu.TabIndex = 5;
            this.menu.Tag = 0;
            // 
            // describe
            // 
            this.describe.Name = "describe";
            this.describe.Padding = new System.Windows.Forms.Padding(0);
            this.describe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.describe.Size = new System.Drawing.Size(64, 24);
            this.describe.Text = "описание";
            this.describe.Click += new System.EventHandler(this.describe_Click);
            // 
            // update
            // 
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(0);
            this.update.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.update.Size = new System.Drawing.Size(63, 24);
            this.update.Text = "обновить";
            this.update.Click += new System.EventHandler(this.Update);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(0);
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(67, 24);
            this.save.Text = "сохранить";
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.Save);
            // 
            // diagram
            // 
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(80, 24);
            this.diagram.Text = "диаграмма";
            this.diagram.Visible = false;
            this.diagram.Click += new System.EventHandler(this.diagram_Click);
            // 
            // exit
            // 
            this.exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(0);
            this.exit.Size = new System.Drawing.Size(55, 24);
            this.exit.Text = "закрыть";
            this.exit.Click += new System.EventHandler(this.Exit);
            // 
            // searchopen
            // 
            this.searchopen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchopen.Name = "searchopen";
            this.searchopen.Padding = new System.Windows.Forms.Padding(0);
            this.searchopen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchopen.Size = new System.Drawing.Size(44, 24);
            this.searchopen.Text = "поиск";
            this.searchopen.Click += new System.EventHandler(this.OpenSearch);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.copy.Size = new System.Drawing.Size(45, 24);
            this.copy.Text = "copy";
            this.copy.Visible = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // Psearch
            // 
            this.Psearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Psearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Psearch.Controls.Add(this.columns);
            this.Psearch.Controls.Add(this.p3);
            this.Psearch.Controls.Add(this.Bsearch);
            this.Psearch.Controls.Add(this.Breset);
            this.Psearch.Controls.Add(this.p2);
            this.Psearch.Controls.Add(this.p1);
            this.Psearch.Controls.Add(this.text);
            this.Psearch.Location = new System.Drawing.Point(126, 24);
            this.Psearch.Name = "Psearch";
            this.Psearch.Size = new System.Drawing.Size(174, 121);
            this.Psearch.TabIndex = 2;
            this.Psearch.Tag = 0;
            this.Psearch.Visible = false;
            // 
            // columns
            // 
            this.columns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.columns.FormattingEnabled = true;
            this.columns.Location = new System.Drawing.Point(3, 3);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(137, 23);
            this.columns.TabIndex = 0;
            this.columns.Tag = 0;
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Location = new System.Drawing.Point(3, 72);
            this.p3.Margin = new System.Windows.Forms.Padding(1);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(166, 19);
            this.p3.TabIndex = 4;
            this.p3.Tag = 0;
            this.p3.Text = "регулярные выражения";
            this.p3.UseVisualStyleBackColor = true;
            this.p3.Click += new System.EventHandler(this.Search);
            // 
            // Bsearch
            // 
            this.Bsearch.AutoSize = true;
            this.Bsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsearch.Location = new System.Drawing.Point(143, 91);
            this.Bsearch.Margin = new System.Windows.Forms.Padding(2);
            this.Bsearch.Name = "Bsearch";
            this.Bsearch.Size = new System.Drawing.Size(26, 27);
            this.Bsearch.TabIndex = 6;
            this.Bsearch.Tag = 1;
            this.Bsearch.Text = ">";
            this.Bsearch.UseVisualStyleBackColor = true;
            this.Bsearch.Click += new System.EventHandler(this.Search);
            // 
            // Breset
            // 
            this.Breset.AutoSize = true;
            this.Breset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Breset.Location = new System.Drawing.Point(143, 1);
            this.Breset.Margin = new System.Windows.Forms.Padding(2);
            this.Breset.Name = "Breset";
            this.Breset.Size = new System.Drawing.Size(26, 27);
            this.Breset.TabIndex = 1;
            this.Breset.Tag = 1;
            this.Breset.Text = "x";
            this.Breset.UseVisualStyleBackColor = true;
            this.Breset.Click += new System.EventHandler(this.Reset);
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(3, 51);
            this.p2.Margin = new System.Windows.Forms.Padding(1);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(145, 19);
            this.p2.TabIndex = 3;
            this.p2.Tag = 0;
            this.p2.Text = "выражение целиком";
            this.p2.UseVisualStyleBackColor = true;
            this.p2.Click += new System.EventHandler(this.Search);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(3, 30);
            this.p1.Margin = new System.Windows.Forms.Padding(1);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(145, 19);
            this.p1.TabIndex = 2;
            this.p1.Tag = 0;
            this.p1.Text = "учитывать регистр";
            this.p1.UseVisualStyleBackColor = true;
            this.p1.Click += new System.EventHandler(this.Search);
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text.Location = new System.Drawing.Point(3, 93);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(137, 23);
            this.text.TabIndex = 5;
            this.text.Tag = 0;
            this.text.TextChanged += new System.EventHandler(this.Search);
            // 
            // nullStrip
            // 
            this.nullStrip.Name = "contextMenuStrip1";
            this.nullStrip.ShowImageMargin = false;
            this.nullStrip.Size = new System.Drawing.Size(36, 4);
            // 
            // selector
            // 
            this.selector.AutoClose = false;
            this.selector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripSeparator1});
            this.selector.Name = "selector";
            this.selector.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.selector.ShowCheckMargin = true;
            this.selector.ShowImageMargin = false;
            this.selector.Size = new System.Drawing.Size(158, 54);
            this.selector.MouseLeave += new System.EventHandler(this.close_selector);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem8.Text = "закрыть";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.close_selector);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem9.Text = "отобразить все";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // imageSelector
            // 
            this.imageSelector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem10});
            this.imageSelector.Name = "imageSelector";
            this.imageSelector.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.imageSelector.ShowImageMargin = false;
            this.imageSelector.Size = new System.Drawing.Size(182, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem10.Text = "просмотр изображения";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // DataTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.nullStrip;
            this.Controls.Add(this.Psearch);
            this.Controls.Add(this.data);
            this.Controls.Add(this.description);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(290, 150);
            this.Name = "DataTableView";
            this.Size = new System.Drawing.Size(300, 175);
            this.Load += new System.EventHandler(this.DataTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.context.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Psearch.ResumeLayout(false);
            this.Psearch.PerformLayout();
            this.selector.ResumeLayout(false);
            this.imageSelector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Panel Psearch;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.CheckBox p3;
        private System.Windows.Forms.CheckBox p2;
        private System.Windows.Forms.CheckBox p1;
        private System.Windows.Forms.ComboBox columns;
        private System.Windows.Forms.Button Bsearch;
        private System.Windows.Forms.Button Breset;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ContextMenuStrip nullStrip;
        private System.Windows.Forms.ToolStripMenuItem _clearSelection;
        private System.Windows.Forms.ToolStripMenuItem _setNull;
        private System.Windows.Forms.ToolStripMenuItem _selectColumn;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripMenuItem _foreignTable;
        private System.Windows.Forms.ToolStripMenuItem _insertForeign;
        private System.Windows.Forms.ToolStripMenuItem _foreignKeys;
        private System.Windows.Forms.ToolStripMenuItem _deleteRow;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem update;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem searchopen;
        private System.Windows.Forms.ToolStripMenuItem describe;
        private System.Windows.Forms.ContextMenuStrip selector;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ContextMenuStrip imageSelector;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem report;
        private System.Windows.Forms.ToolStripMenuItem diagram;
        private System.Windows.Forms.ToolStripMenuItem copy;
    }
}
