namespace УИС.Forms
{
    partial class ConnectForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Bsave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.provider = new System.Windows.Forms.ComboBox();
            this.Bconnect = new System.Windows.Forms.Button();
            this.Breset = new System.Windows.Forms.Button();
            this.Bopen = new System.Windows.Forms.Button();
            this.fullpath = new System.Windows.Forms.TextBox();
            this.Lprovider = new System.Windows.Forms.Label();
            this.Lpath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bsave
            // 
            this.Bsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bsave.AutoSize = true;
            this.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsave.Location = new System.Drawing.Point(190, 102);
            this.Bsave.Margin = new System.Windows.Forms.Padding(2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(82, 27);
            this.Bsave.TabIndex = 8;
            this.Bsave.Tag = 1;
            this.Bsave.Text = "сохранить";
            this.Bsave.UseVisualStyleBackColor = true;
            this.Bsave.Click += new System.EventHandler(this.Save);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(141, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "полный путь";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // provider
            // 
            this.provider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.provider.FormattingEnabled = true;
            this.provider.Location = new System.Drawing.Point(95, 72);
            this.provider.MaximumSize = new System.Drawing.Size(450, 0);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(177, 23);
            this.provider.TabIndex = 5;
            this.provider.Tag = 0;
            this.provider.SelectedIndexChanged += new System.EventHandler(this.provider_SelectedIndexChanged);
            // 
            // Bconnect
            // 
            this.Bconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bconnect.AutoSize = true;
            this.Bconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bconnect.Location = new System.Drawing.Point(13, 102);
            this.Bconnect.Margin = new System.Windows.Forms.Padding(2);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(89, 27);
            this.Bconnect.TabIndex = 6;
            this.Bconnect.Tag = 1;
            this.Bconnect.Text = "подключить";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.Connect);
            // 
            // Breset
            // 
            this.Breset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Breset.AutoSize = true;
            this.Breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Breset.Location = new System.Drawing.Point(106, 102);
            this.Breset.Margin = new System.Windows.Forms.Padding(2);
            this.Breset.Name = "Breset";
            this.Breset.Size = new System.Drawing.Size(80, 27);
            this.Breset.TabIndex = 7;
            this.Breset.Tag = 1;
            this.Breset.Text = "сбросить";
            this.Breset.UseVisualStyleBackColor = true;
            this.Breset.Click += new System.EventHandler(this.Reset);
            // 
            // Bopen
            // 
            this.Bopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bopen.Location = new System.Drawing.Point(95, 12);
            this.Bopen.Name = "Bopen";
            this.Bopen.Size = new System.Drawing.Size(40, 23);
            this.Bopen.TabIndex = 1;
            this.Bopen.Tag = 1;
            this.Bopen.Text = "∙∙∙";
            this.Bopen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bopen.UseVisualStyleBackColor = true;
            this.Bopen.Click += new System.EventHandler(this.OpenFile);
            // 
            // fullpath
            // 
            this.fullpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullpath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::УИС.Properties.Settings.Default, "path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fullpath.Location = new System.Drawing.Point(12, 43);
            this.fullpath.MaximumSize = new System.Drawing.Size(530, 23);
            this.fullpath.Name = "fullpath";
            this.fullpath.Size = new System.Drawing.Size(260, 23);
            this.fullpath.TabIndex = 3;
            this.fullpath.Tag = 0;
            this.fullpath.Text = global::УИС.Properties.Settings.Default.path;
            // 
            // Lprovider
            // 
            this.Lprovider.AutoSize = true;
            this.Lprovider.Location = new System.Drawing.Point(12, 75);
            this.Lprovider.Name = "Lprovider";
            this.Lprovider.Size = new System.Drawing.Size(77, 15);
            this.Lprovider.TabIndex = 4;
            this.Lprovider.Text = "провайдер:";
            // 
            // Lpath
            // 
            this.Lpath.AutoSize = true;
            this.Lpath.Location = new System.Drawing.Point(12, 17);
            this.Lpath.Name = "Lpath";
            this.Lpath.Size = new System.Drawing.Size(77, 15);
            this.Lpath.TabIndex = 0;
            this.Lpath.Text = "имя файла:";
            this.Lpath.DoubleClick += new System.EventHandler(this.openFile);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.Bsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.Bconnect);
            this.Controls.Add(this.Breset);
            this.Controls.Add(this.Bsave);
            this.Controls.Add(this.Bopen);
            this.Controls.Add(this.fullpath);
            this.Controls.Add(this.Lprovider);
            this.Controls.Add(this.Lpath);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "ConnectForm";
            this.Text = "Настройки подключения";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lpath;
        private System.Windows.Forms.TextBox fullpath;
        private System.Windows.Forms.Button Bopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Breset;
        private System.Windows.Forms.Label Lprovider;
        private System.Windows.Forms.Button Bconnect;
        private System.Windows.Forms.ComboBox provider;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}