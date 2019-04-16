using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        Solver solver;
        public Form1()
        {
            InitializeComponent();
            //Solver class
            solver = new Solver();
        }

        private void MegoldButton_Click(object sender, EventArgs e)
        {
            solver.Solve();
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            string s = tb.Name;
            int x = Convert.ToInt32(s[2]);
            int y = Convert.ToInt32(s[3]);
            Cell c = new Cell(Convert.ToInt32(tb.Text), x, y);
            if (solver.AddCell(c))
            {
                this.LBnemlehet.Visible = false;
            }
            else
            {
                this.LBnemlehet.Visible = true;
            }
        }
    }
}
