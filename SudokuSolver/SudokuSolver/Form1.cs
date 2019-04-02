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
                    string s = "TB" + i.ToString() + j.ToString();
                    TextBox tb = (TextBox)this.Controls[s];
                }
            }
            Solver s = new Solver(tomb);
        }
    }
}
