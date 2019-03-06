using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace УИС.Forms
{
    public partial class Diagram : Form
    {
        SeriesChartType type = SeriesChartType.Column;
        static Diagram self;
        public static void ShowForm(DataGridView Table)
        { self.Update(Table); self.ShowDialog(); }
        static Diagram() { self = new Diagram(); }
        Diagram() { InitializeComponent(); }
        void Update(DataGridView Table)
        {
            chart.Series.Clear();
            int cols = Table.Columns.Count, rows = Table.Rows.Count;
            if (Table.AllowUserToAddRows) rows--;
            for (int i = 0; i < rows; i++)
            {
                Series S = chart.Series.Add((Table[0, i].Value ?? "null").ToString());
                S.ChartType = type;
                for (int j = 1; j < cols; j++)
                    chart.Series[i].Points.AddXY(Table.Columns[j].HeaderText, Table[j, i].Value);
            }
        }
    }
}