namespace УИС.Forms
{
    partial class Working
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Working));
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.SCcontrols = new System.Windows.Forms.SplitContainer();
            this.Vlist = new System.Windows.Forms.ComboBox();
            this.tabFormControl1 = new УИС.Components.TabFormControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SCcontrols)).BeginInit();
            this.SCcontrols.Panel1.SuspendLayout();
            this.SCcontrols.Panel2.SuspendLayout();
            this.SCcontrols.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "table.png");
            this.Icons.Images.SetKeyName(1, "view.png");
            // 
            // SCcontrols
            // 
            this.SCcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCcontrols.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SCcontrols.Location = new System.Drawing.Point(0, 24);
            this.SCcontrols.Name = "SCcontrols";
            // 
            // SCcontrols.Panel1
            // 
            this.SCcontrols.Panel1.Controls.Add(this.Vlist);
            this.SCcontrols.Panel1MinSize = 100;
            // 
            // SCcontrols.Panel2
            // 
            this.SCcontrols.Panel2.Controls.Add(this.tabFormControl1);
            this.SCcontrols.Panel2MinSize = 200;
            this.SCcontrols.Size = new System.Drawing.Size(609, 285);
            this.SCcontrols.SplitterDistance = 135;
            this.SCcontrols.SplitterWidth = 3;
            this.SCcontrols.TabIndex = 1;
            this.SCcontrols.DoubleClick += new System.EventHandler(this.HideList);
            // 
            // Vlist
            // 
            this.Vlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Vlist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Vlist.Location = new System.Drawing.Point(0, 0);
            this.Vlist.Name = "Vlist";
            this.Vlist.Size = new System.Drawing.Size(133, 283);
            this.Vlist.TabIndex = 0;
            this.Vlist.Tag = 0;
            this.Vlist.SelectedIndexChanged += new System.EventHandler(this.SelectView);
            this.Vlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vlist_KeyDown);
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormControl1.ImageList = this.Icons;
            this.tabFormControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Multiline = true;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabFormControl1.SelectedIndex = 0;
            this.tabFormControl1.Size = new System.Drawing.Size(469, 283);
            this.tabFormControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem1.Text = "закрыть";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem2.Text = "закрыть все";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem3.Text = "закрыть все кроме текущей";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripSeparator2,
            this.toolStripMenuItem9,
            this.toolStripMenuItem4,
            this.toolStripSeparator3,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem5,
            this.toolStripSeparator4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripSeparator5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Tag = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(24, 24);
            this.toolStripMenuItem14.Text = "<";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.HideList);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem9.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem9.Text = "помощь";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.Bhelp_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem4.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem4.Text = "обновить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItem12.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem12.Text = "таблицы";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.ShowTables);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem13.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.toolStripMenuItem13.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem13.Text = "запросы";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.ShowViews);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(52, 24);
            this.toolStripMenuItem5.Text = "выход";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItem7.Text = "экспорт";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem8.Text = "печать";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.Bprint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem6.Text = "темы";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.Btheme_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem10.Text = "управление";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.Badmin_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.toolStripMenuItem11.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem11.Text = "screenshot";
            this.toolStripMenuItem11.Visible = false;
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // Working
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 309);
            this.Controls.Add(this.SCcontrols);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(516, 237);
            this.Name = "Working";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Working_FormClosed);
            this.SCcontrols.Panel1.ResumeLayout(false);
            this.SCcontrols.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCcontrols)).EndInit();
            this.SCcontrols.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Vlist;
        private System.Windows.Forms.SplitContainer SCcontrols;
        private System.Windows.Forms.ImageList Icons;
        private Components.TabFormControl tabFormControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
    }
}