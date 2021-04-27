using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Task1_ClassLibrary;

namespace Task1
{
    public partial class MainForm : Form
    {
        private int[][] matrix;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(XT.Text);
            var y = Convert.ToInt32(YT.Text);
            this.InputView.ColumnCount = x;
            matrix = Enumerable.Range(0, x).Select(z => Enumerable.Range(0, y).Select(w => 0).ToArray()).ToArray();
            for (int i = 0; i < y; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(this.InputView);
                for (int j = 0; j < x; j++)
                {
                    row.Cells[j].Value = matrix[i][j];
                }
                this.InputView.Rows.Add(row);
            }
        }

        private void GridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var x = Convert.ToInt32(XT.Text);
            var y = Convert.ToInt32(YT.Text);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i][j] = Convert.ToInt32(this.InputView.Rows[i].Cells[j].Value);
                }
            }
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            var solved = new Task1Solver(this.matrix).DoSolve();
            var x = solved.Length;
            var y = x > 0 ? solved[0].Length : 0;
            this.OutputView.Rows.Clear();
            this.OutputView.ColumnCount = x;
            for (int i = 0; i < y; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(this.OutputView);
                for (int j = 0; j < x; j++)
                {
                    row.Cells[j].Value = solved[j][i];
                }
                this.OutputView.Rows.Add(row);
            }
        }
    }
}
