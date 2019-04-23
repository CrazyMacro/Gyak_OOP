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
        public int Value { get => value; set => Value = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public HashSet<int> PossibleNums { get => possibleNums; set => possibleNums = value; }

        private int x, y;

        public Cell(int value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
            PossibleNums = new HashSet<int>();
        }

        public int GetPossibleLength()
        {
            return PossibleNums.Count;
        }

        public void AddPossibleNum(int toAdd)
        {
            if (toAdd > 0 && toAdd < 10)
            {
                PossibleNums.Add(toAdd);
            }
        }

        public void RemovePossibleNum(int toRemove)
        {
            PossibleNums.Remove(toRemove);
        }

        public void SetResult()
        {
            if (GetPossibleLength() == 1)
            {
                value = PossibleNums.Single();
            }
        }

        public int SetMin()
        {
            value = PossibleNums.Min();
            return value;
        }
    }
}