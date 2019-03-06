using System;
using System.Drawing;
using System.Windows.Forms;

namespace УИС.Components
{
    class TabFormControl : TabControl
    {
        static Form Default() { return new Form(); }
        public static Func<Form> FormCreator { get; set; }
        static TabFormControl() { FormCreator = Default; }
        public TabFormControl()
        {
            MouseDoubleClick += TabFormControl_MouseDoubleClick;
        }
        static void CopyControls(Control.ControlCollection collection, Control.ControlCollection from)
        {
            for (int i = from.Count - 1; i >= 0; i--)
                collection.Add(from[0]);
        }
        private void TabFormControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var control = sender as TabControl;
            var tab = control.SelectedTab;
            TabToForm(tab);
        }

        private void TabToForm(TabPage tab)
        {
            var form = FormCreator();
            tab.FindForm().AddOwnedForm(form);
            if (tab.BackColor.A == 255) form.BackColor = tab.BackColor;
            form.ClientSize = tab.Size;
            form.Text = tab.Text;
            form.Name = tab.Name;
            CopyControls(form.Controls, tab.Controls);
            TabPages.Remove(tab);
            form.Deactivate += Form_Deactivate;
            form.Show();
            if ((int)(form.Tag = tab.ImageIndex) != -1)
                form.Icon = Icon.FromHandle(new Bitmap(ImageList.Images[tab.ImageIndex], 16, 16).GetHicon());
        }
        private void FormToTab(Form form)
        {
            var tab = new TabPage(form.Text);
            tab.Name = form.Name;
            tab.Size = form.ClientSize;
            tab.BackColor = form.BackColor;
            CopyControls(tab.Controls, form.Controls);
            tab.ImageIndex = (int)form.Tag;
            TabPages.Add(tab);
            SelectedTab = tab;
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            var f = sender as Form;
            if (f.WindowState == FormWindowState.Minimized)
            {
                FormToTab(f);
                f.Close();
            }
        }

        public void AddTab(string name, int img, params Control[] collection)
        {
            TabPage tab = new TabPage(name);
            tab.Name = name;
            tab.Controls.AddRange(collection);
            tab.ImageIndex = img;
            TabPages.Add(tab);
            SelectedTab = tab;
            #region not use for another
            tab.Tag = 0;
            Theme.Current.Apply(tab);
            #endregion
        }
    }
}
