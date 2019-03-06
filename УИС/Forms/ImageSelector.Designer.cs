namespace УИС.Forms
{
    partial class ImageSelector
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bcancel = new System.Windows.Forms.Button();
            this.Baccept = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Mdelte = new System.Windows.Forms.ToolStripMenuItem();
            this.Msave = new System.Windows.Forms.ToolStripMenuItem();
            this.Mopen = new System.Windows.Forms.ToolStripMenuItem();
            this.Mresize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Bcancel
            // 
            this.Bcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bcancel.AutoSize = true;
            this.Bcancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcancel.Location = new System.Drawing.Point(9, 265);
            this.Bcancel.Margin = new System.Windows.Forms.Padding(0);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(61, 27);
            this.Bcancel.TabIndex = 7;
            this.Bcancel.Tag = 1;
            this.Bcancel.Text = "Отмена";
            this.Bcancel.UseVisualStyleBackColor = true;
            // 
            // Baccept
            // 
            this.Baccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Baccept.AutoSize = true;
            this.Baccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Baccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Baccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baccept.Location = new System.Drawing.Point(376, 265);
            this.Baccept.Margin = new System.Windows.Forms.Padding(0);
            this.Baccept.Name = "Baccept";
            this.Baccept.Size = new System.Drawing.Size(68, 27);
            this.Baccept.TabIndex = 7;
            this.Baccept.Tag = 1;
            this.Baccept.Text = "Принять";
            this.Baccept.UseVisualStyleBackColor = true;
            this.Baccept.Click += new System.EventHandler(this.accept);
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Все изображения|*.bmp;*.gif;*.jpeg;*.jpg;*.jpe;*.jfif;*.png;*.tif;*.tiff|BMP|*.bm" +
    "p|GIF|*.gif|JPEG|*.jpeg;*.jpg;*.jpe;*.jfif|PNG|*.png|TIFF|*.tif;*.tiff";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 231);
            this.panel1.TabIndex = 8;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mdelte,
            this.Msave,
            this.Mopen,
            this.Mresize});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(453, 24);
            this.menu.TabIndex = 9;
            this.menu.Tag = 0;
            this.menu.Text = "menuStrip1";
            // 
            // Mdelte
            // 
            this.Mdelte.Name = "Mdelte";
            this.Mdelte.Size = new System.Drawing.Size(62, 20);
            this.Mdelte.Text = "удалить";
            this.Mdelte.Click += new System.EventHandler(this.delete);
            // 
            // Msave
            // 
            this.Msave.Name = "Msave";
            this.Msave.Size = new System.Drawing.Size(75, 20);
            this.Msave.Text = "сохранить";
            this.Msave.Click += new System.EventHandler(this.save);
            // 
            // Mopen
            // 
            this.Mopen.Name = "Mopen";
            this.Mopen.Size = new System.Drawing.Size(52, 20);
            this.Mopen.Text = "обзор";
            this.Mopen.Click += new System.EventHandler(this.open);
            // 
            // Mresize
            // 
            this.Mresize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.Mresize.Name = "Mresize";
            this.Mresize.Size = new System.Drawing.Size(114, 20);
            this.Mresize.Text = "изменить размер";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "10%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.resize);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem6.Text = "50%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.resize);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem7.Text = "75%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.resize);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem8.Text = "100%";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.resize);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.MaxLength = 5;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.resize);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPEG|*.jpeg;*.jpg;*.jpe;*.jfif|PNG|*.png|TIFF|*.tif;*.tiff";
            // 
            // ImageSelector
            // 
            this.AcceptButton = this.Baccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bcancel;
            this.ClientSize = new System.Drawing.Size(453, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Baccept);
            this.Controls.Add(this.Bcancel);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(347, 340);
            this.Name = "ImageSelector";
            this.Text = "Просмотр изображений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bcancel;
        private System.Windows.Forms.Button Baccept;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Mdelte;
        private System.Windows.Forms.ToolStripMenuItem Msave;
        private System.Windows.Forms.ToolStripMenuItem Mopen;
        private System.Windows.Forms.ToolStripMenuItem Mresize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}