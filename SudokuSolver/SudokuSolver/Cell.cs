using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Cell
    {
        private int value = 0;
        private HashSet<int> possibleNums;
        public int Value { get => value;}

        public int getPossibleLength()
        {
            return possibleNums.Count;
        }

        public void addPossibleNum(int toAdd)
        {
            if (toAdd > 0 && toAdd < 10)
            {
                possibleNums.Add(toAdd);
            }
        }

        public void removePossibleNum(int toRemove)
        {
            possibleNums.Remove(toRemove);
        }

        public void setResult()
        {
            if (getPossibleLength() == 1)
            {
                value = possibleNums.Single();
            }
        }

        public int setMin()
        {
            value = possibleNums.Min();
            return value;
        }
    }
}