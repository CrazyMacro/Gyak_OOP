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
        public Form1()
        {
            InitializeComponent();
        }

        private void MegoldButton_Click(object sender, EventArgs e)
        {
            this.MegoldMeneteBtn.Visible = true;
            int[,] tomb = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string nev = "TB" + i.ToString() + j.ToString();
                    TextBox tb = (TextBox)this.Controls[nev];
                    tomb[i, j] = Convert.ToInt32(tb.Text);
                }
            }
            Solver s = new Solver(tomb);
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            string s = tb.Name;
            int x = Convert.ToInt32(s[2]);
            int y = Convert.ToInt32(s[3]);
            Cell c = new Cell(Convert.ToInt32(tb.Text), x, y);
            if (AddCell(c))
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
