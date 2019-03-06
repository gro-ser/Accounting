namespace УИС.Forms
{
    partial class Loadder
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
            this.Bhelp = new System.Windows.Forms.Button();
            this.Bsettings = new System.Windows.Forms.Button();
            this.Btheme = new System.Windows.Forms.Button();
            this.Benter = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.Luser = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ComboBox();
            this.Lpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bhelp
            // 
            this.Bhelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bhelp.AutoSize = true;
            this.Bhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bhelp.Location = new System.Drawing.Point(114, 65);
            this.Bhelp.Name = "Bhelp";
            this.Bhelp.Size = new System.Drawing.Size(61, 29);
            this.Bhelp.TabIndex = 6;
            this.Bhelp.Tag = 1;
            this.Bhelp.Text = "Помощь";
            this.Bhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bhelp.UseVisualStyleBackColor = false;
            this.Bhelp.Click += new System.EventHandler(this.SHelp);
            // 
            // Bsettings
            // 
            this.Bsettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bsettings.AutoSize = true;
            this.Bsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsettings.Location = new System.Drawing.Point(6, 65);
            this.Bsettings.Name = "Bsettings";
            this.Bsettings.Size = new System.Drawing.Size(96, 29);
            this.Bsettings.TabIndex = 5;
            this.Bsettings.Tag = 1;
            this.Bsettings.Text = "Покдлючение";
            this.Bsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsettings.UseVisualStyleBackColor = false;
            this.Bsettings.Click += new System.EventHandler(this.SSettings);
            // 
            // Btheme
            // 
            this.Btheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btheme.AutoSize = true;
            this.Btheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btheme.Location = new System.Drawing.Point(187, 65);
            this.Btheme.Name = "Btheme";
            this.Btheme.Size = new System.Drawing.Size(124, 29);
            this.Btheme.TabIndex = 7;
            this.Btheme.Tag = 1;
            this.Btheme.Text = "Темы оформления";
            this.Btheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btheme.UseVisualStyleBackColor = false;
            this.Btheme.Click += new System.EventHandler(this.SThemeSelect);
            // 
            // Benter
            // 
            this.Benter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Benter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Benter.Location = new System.Drawing.Point(230, 6);
            this.Benter.Name = "Benter";
            this.Benter.Size = new System.Drawing.Size(81, 54);
            this.Benter.TabIndex = 4;
            this.Benter.Tag = 1;
            this.Benter.Text = "ВХОД";
            this.Benter.UseVisualStyleBackColor = false;
            this.Benter.Click += new System.EventHandler(this.Login);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(84, 37);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(140, 23);
            this.password.TabIndex = 3;
            this.password.Tag = 0;
            this.password.UseSystemPasswordChar = true;
            // 
            // Luser
            // 
            this.Luser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Luser.AutoSize = true;
            this.Luser.Location = new System.Drawing.Point(8, 9);
            this.Luser.Name = "Luser";
            this.Luser.Size = new System.Drawing.Size(70, 15);
            this.Luser.TabIndex = 0;
            this.Luser.Text = "работник:";
            this.Luser.Click += new System.EventHandler(this.Luser_Click);
            this.Luser.DoubleClick += new System.EventHandler(this.Luser_DoubleClick);
            // 
            // user
            // 
            this.userList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userList.BackColor = System.Drawing.SystemColors.Window;
            this.userList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(84, 6);
            this.userList.Name = "user";
            this.userList.Size = new System.Drawing.Size(140, 23);
            this.userList.TabIndex = 1;
            this.userList.Tag = 0;
            // 
            // Lpassword
            // 
            this.Lpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lpassword.AutoSize = true;
            this.Lpassword.Checked = true;
            this.Lpassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lpassword.Location = new System.Drawing.Point(6, 38);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(75, 19);
            this.Lpassword.TabIndex = 2;
            this.Lpassword.Text = "пароль:";
            this.Lpassword.UseVisualStyleBackColor = true;
            this.Lpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Loadder
            // 
            this.AcceptButton = this.Benter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 99);
            this.Controls.Add(this.Bhelp);
            this.Controls.Add(this.Bsettings);
            this.Controls.Add(this.Btheme);
            this.Controls.Add(this.Benter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Luser);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.Lpassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loadder";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.Label Luser;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Benter;
        private System.Windows.Forms.Button Btheme;
        private System.Windows.Forms.Button Bsettings;
        private System.Windows.Forms.Button Bhelp;
        private System.Windows.Forms.CheckBox Lpassword;
    }
}

