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
    public partial class ExportForm : /*Theme*/Form
    {
        string name;
        DataGridView grid;

        public ExportForm(DataGridView grid, string name)
        {
            this.grid = grid;
            this.name = name;
            InitializeComponent();
            comboBox1.Items.AddRange(new Exporter[]
            {
                new CSVExport(), new TextExport()
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exporter exporter = comboBox1.SelectedItem as Exporter;
            if(exporter == null)
            {
                MessageBox.Show("NULL!!!");
                return;
            }
            saveFileDialog1.Filter = exporter.FileFilter();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            exporter.Export(grid, name, saveFileDialog1.FileName);
        }
    }
}
