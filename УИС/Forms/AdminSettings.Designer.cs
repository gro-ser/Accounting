namespace УИС.Forms
{
    partial class AdminSettings
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
            this.Lpath = new System.Windows.Forms.Label();
            this.adminPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.providers = new System.Windows.Forms.TextBox();
            this.Bsave = new System.Windows.Forms.Button();
            this.Breset = new System.Windows.Forms.Button();
            this.Bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lpath
            // 
            this.Lpath.AutoSize = true;
            this.Lpath.Location = new System.Drawing.Point(13, 12);
            this.Lpath.Name = "Lpath";
            this.Lpath.Size = new System.Drawing.Size(161, 15);
            this.Lpath.TabIndex = 0;
            this.Lpath.Text = "пароль администратора:";
            // 
            // adminPass
            // 
            this.adminPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::УИС.Properties.Settings.Default, "AdminPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adminPass.Location = new System.Drawing.Point(180, 12);
            this.adminPass.Name = "adminPass";
            this.adminPass.Size = new System.Drawing.Size(184, 23);
            this.adminPass.TabIndex = 1;
            this.adminPass.Tag = 0;
            this.adminPass.Text = global::УИС.Properties.Settings.Default.AdminPass;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "пароль пользователя:";
            // 
            // userPass
            // 
            this.userPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::УИС.Properties.Settings.Default, "UserPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userPass.Location = new System.Drawing.Point(180, 41);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(184, 23);
            this.userPass.TabIndex = 3;
            this.userPass.Tag = 0;
            this.userPass.Text = global::УИС.Properties.Settings.Default.UserPass;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "сохранённые провайдеры:";
            // 
            // providers
            // 
            this.providers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.providers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.providers.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::УИС.Properties.Settings.Default, "providers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.providers.Location = new System.Drawing.Point(16, 89);
            this.providers.Multiline = true;
            this.providers.Name = "providers";
            this.providers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.providers.Size = new System.Drawing.Size(348, 38);
            this.providers.TabIndex = 5;
            this.providers.Tag = 0;
            this.providers.Text = global::УИС.Properties.Settings.Default.providers;
            this.providers.WordWrap = false;
            // 
            // Bsave
            // 
            this.Bsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bsave.AutoSize = true;
            this.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsave.Location = new System.Drawing.Point(282, 130);
            this.Bsave.Margin = new System.Windows.Forms.Padding(2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(82, 27);
            this.Bsave.TabIndex = 8;
            this.Bsave.Tag = 1;
            this.Bsave.Text = "сохранить";
            this.Bsave.UseVisualStyleBackColor = true;
            this.Bsave.Click += new System.EventHandler(this.Save);
            // 
            // Breset
            // 
            this.Breset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Breset.AutoSize = true;
            this.Breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Breset.Location = new System.Drawing.Point(203, 130);
            this.Breset.Margin = new System.Windows.Forms.Padding(2);
            this.Breset.Name = "Breset";
            this.Breset.Size = new System.Drawing.Size(75, 27);
            this.Breset.TabIndex = 7;
            this.Breset.Tag = 1;
            this.Breset.Text = "сбросить";
            this.Breset.UseVisualStyleBackColor = true;
            this.Breset.Click += new System.EventHandler(this.Reset);
            // 
            // Bexit
            // 
            this.Bexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bexit.AutoSize = true;
            this.Bexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bexit.Location = new System.Drawing.Point(131, 130);
            this.Bexit.Margin = new System.Windows.Forms.Padding(2);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(68, 27);
            this.Bexit.TabIndex = 6;
            this.Bexit.Tag = 1;
            this.Bexit.Text = "закрыть";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Exit);
            // 
            // AdminSettings
            // 
            this.AcceptButton = this.Bsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bexit;
            this.ClientSize = new System.Drawing.Size(376, 166);
            this.Controls.Add(this.providers);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.Breset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminPass);
            this.Controls.Add(this.Lpath);
            this.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.MinimumSize = new System.Drawing.Size(277, 205);
            this.Name = "AdminSettings";
            this.ShowIcon = false;
            this.Text = "Настройки администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lpath;
        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox providers;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Breset;
        private System.Windows.Forms.Button Bexit;
    }
}