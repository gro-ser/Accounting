using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class ConnectSettings : ThemeForm
    {
        public ConnectSettings()
        {
            InitializeComponent();
        }

        private void ConnectSettings_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = new System.Data.OleDb.OleDbConnectionStringBuilder();
        }
    }
}
