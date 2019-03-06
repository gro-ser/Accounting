namespace УИС.Forms
{
    partial class ThemeSelect
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Bapply = new System.Windows.Forms.Button();
            this.Bcancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Пример1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пример2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._Button = new System.Windows.Forms.Button();
            this._Back = new System.Windows.Forms.Button();
            this._BackColor = new System.Windows.Forms.Button();
            this._ForeColor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // Bapply
            // 
            this.Bapply.AutoSize = true;
            this.Bapply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bapply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bapply.Location = new System.Drawing.Point(344, 223);
            this.Bapply.Name = "Bapply";
            this.Bapply.Size = new System.Drawing.Size(82, 27);
            this.Bapply.TabIndex = 10;
            this.Bapply.Tag = 1;
            this.Bapply.Text = "применить";
            this.Bapply.UseVisualStyleBackColor = true;
            this.Bapply.Click += new System.EventHandler(this.Accept);
            // 
            // Bcancel
            // 
            this.Bcancel.AutoSize = true;
            this.Bcancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcancel.Location = new System.Drawing.Point(277, 223);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(61, 27);
            this.Bcancel.TabIndex = 10;
            this.Bcancel.Tag = 1;
            this.Bcancel.Text = "отмена";
            this.Bcancel.UseVisualStyleBackColor = true;
            this.Bcancel.Click += new System.EventHandler(this.Cancel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Пример1,
            this.Пример2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(162, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.Size = new System.Drawing.Size(264, 203);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Tag = 2;
            // 
            // Пример1
            // 
            this.Пример1.HeaderText = "Пример1";
            this.Пример1.Name = "Пример1";
            // 
            // Пример2
            // 
            this.Пример2.HeaderText = "Пример2";
            this.Пример2.Name = "Пример2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет кнопок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Задний фон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фон цвета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет текста";
            // 
            // _Button
            // 
            this._Button.FlatAppearance.BorderSize = 0;
            this._Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Button.Location = new System.Drawing.Point(13, 204);
            this._Button.Name = "_Button";
            this._Button.Size = new System.Drawing.Size(47, 46);
            this._Button.TabIndex = 7;
            this._Button.UseVisualStyleBackColor = true;
            this._Button.Click += new System.EventHandler(this.ColorSelect);
            // 
            // _Back
            // 
            this._Back.FlatAppearance.BorderSize = 0;
            this._Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Back.Location = new System.Drawing.Point(13, 151);
            this._Back.Name = "_Back";
            this._Back.Size = new System.Drawing.Size(47, 46);
            this._Back.TabIndex = 5;
            this._Back.UseVisualStyleBackColor = true;
            this._Back.Click += new System.EventHandler(this.ColorSelect);
            // 
            // _BackColor
            // 
            this._BackColor.FlatAppearance.BorderSize = 0;
            this._BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._BackColor.Location = new System.Drawing.Point(13, 98);
            this._BackColor.Name = "_BackColor";
            this._BackColor.Size = new System.Drawing.Size(47, 46);
            this._BackColor.TabIndex = 3;
            this._BackColor.UseVisualStyleBackColor = true;
            this._BackColor.Click += new System.EventHandler(this.ColorSelect);
            // 
            // _ForeColor
            // 
            this._ForeColor.FlatAppearance.BorderSize = 0;
            this._ForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ForeColor.Location = new System.Drawing.Point(14, 45);
            this._ForeColor.Name = "_ForeColor";
            this._ForeColor.Size = new System.Drawing.Size(47, 46);
            this._ForeColor.TabIndex = 1;
            this._ForeColor.UseVisualStyleBackColor = true;
            this._ForeColor.Click += new System.EventHandler(this.ColorSelect);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Светлая",
            "Серая",
            "Темная",
            "Своя"});
            this.comboBox1.Location = new System.Drawing.Point(14, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Selected);
            // 
            // ThemeSelect
            // 
            this.AcceptButton = this.Bapply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bcancel;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Back);
            this.Controls.Add(this._BackColor);
            this.Controls.Add(this._ForeColor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Bcancel);
            this.Controls.Add(this.Bapply);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeSelect";
            this.Text = "Выбор темы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bapply;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button _ForeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _BackColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пример1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пример2;
        private System.Windows.Forms.Button Bcancel;
    }
}