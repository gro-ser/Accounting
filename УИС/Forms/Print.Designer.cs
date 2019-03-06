namespace УИС.Forms
{
    partial class Print
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.preview = new System.Windows.Forms.ToolStripMenuItem();
            this.doprint = new System.Windows.Forms.ToolStripMenuItem();
            this.fastprint = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 24);
            this.webBrowser.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(555, 432);
            this.webBrowser.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "HTML Document|*.html|HTM Page|*.htm|Word Document|*.doc|RTF Document|*.rtf";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preview,
            this.doprint,
            this.fastprint,
            this.save,
            this.exit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(555, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Tag = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // preview
            // 
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(74, 24);
            this.preview.Text = "просмотр";
            this.preview.Click += new System.EventHandler(this.PreView);
            // 
            // doprint
            // 
            this.doprint.Name = "doprint";
            this.doprint.Size = new System.Drawing.Size(56, 24);
            this.doprint.Text = "печать";
            this.doprint.Click += new System.EventHandler(this.DoPrint);
            // 
            // fastprint
            // 
            this.fastprint.Name = "fastprint";
            this.fastprint.Size = new System.Drawing.Size(105, 24);
            this.fastprint.Text = "быстрая печать";
            this.fastprint.Click += new System.EventHandler(this.FastPrint);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 24);
            this.save.Text = "сохранить";
            this.save.Click += new System.EventHandler(this.Save);
            // 
            // exit
            // 
            this.exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(52, 24);
            this.exit.Text = "выход";
            this.exit.Click += new System.EventHandler(this.Exit);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 456);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Print";
            this.Text = "Печать";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem preview;
        private System.Windows.Forms.ToolStripMenuItem doprint;
        private System.Windows.Forms.ToolStripMenuItem fastprint;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}