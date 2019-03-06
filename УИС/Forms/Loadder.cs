using System;
using System.Data;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class Loadder : ThemeForm
    {
        object[][] users;
        public Loadder() { InitializeComponent(); }
        private void FormLoad(object sender, EventArgs e)
        {
            if (!DBControl.Connect())
            {
                MessageBox.Show("Не подключено к БД!");
                ConnectForm.ShowForm();
            }
            FillUsers();
#if DEBUG
            try { userList.SelectedIndex = 3; } catch { }
            password.Text = "admin";
            Benter.PerformClick();
#endif
        }

        private void FillUsers()
        {
            if (!DBControl.Connected)
            {
                MessageBox.Show("No Connection!");
                return;
            }
            userList.Items.Clear();
            users = new object[][]
            {
                new object[] { 0, "admin", Properties.Settings.Default.AdminPass, 1 },
                new object[] { 1, "user", Properties.Settings.Default.UserPass, 0 }
            };
            int len = 2;
            DataTable t = DBControl.Select("select * from users");
            if (t != null && t.Columns.Count == 4)
            {
                len = t.Rows.Count;
                users = new object[len][];
                for (int i = 0; i < len; i++) users[i] = t.Rows[i].ItemArray;
            }
            for (int i = 0; i < len; i++) userList.Items.Add(users[i][1]);
        }
        private void Login(object sender, EventArgs e)
        {
            int ind = userList.SelectedIndex;
            if (ind == -1) return;
            if (password.Text.Equals(users[ind][2]))
            {
                bool access = 0 != Convert.ToInt32(users[ind][3]);
                string user = users[ind][1].ToString();
                Hide();
                if (new Working(user, access).ShowDialog() == DialogResult.OK)
                    Show();
                else Close();
            }
            else MessageBox.Show("Неправильный пароль");
            password.Text = "";
        }

        private void SHelp(object sender, EventArgs e)
        {
            Help.ShowForm();
        }
        private void SThemeSelect(object sender, EventArgs e)
        {
            ThemeSelect.ShowForm();
        }
        private void SSettings(object sender, EventArgs e)
        {
            ConnectForm.ShowForm();
            FillUsers();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = Lpassword.Checked;
        }

        private void Luser_DoubleClick(object sender, EventArgs e)
        {
            new ConnectSettings().ShowDialog();
        }

        private void Luser_Click(object sender, EventArgs e)
        {

        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            DBControl.Close();
        }
    }
}