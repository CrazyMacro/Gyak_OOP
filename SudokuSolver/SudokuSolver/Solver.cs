using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Solver
    {
        internal Form1 mainForm;
        HashSet<int> Possible = new HashSet<int>();
        int[,] tomb = new int[9, 9]; 

        public Solver(Form1 mainForm)
        {
            this.mainForm = mainForm;
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    string s = "TB" + i + j;

                }
            }
        }

        void PossibleNum(int toAdd)
        {
            
        }
    }
}
