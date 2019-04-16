using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Solver
    {
        Cell[,] tomb = new Cell[9, 9];
        Dictionary<String, Rectangle> areas = new Dictionary<string, Rectangle>();

        public Solver()
        {
        }

        public Solver(int[,] tomb)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.tomb[i, j] = new Cell(tomb[i, j], i, j);
                }
            }
            FillAreas();
        }

        public bool AddCell(Cell cellToAdd)
        {
            Cell tmpCell = tomb[cellToAdd.X, cellToAdd.Y];
            tomb[cellToAdd.X, cellToAdd.Y] = cellToAdd;
            if (CheckValidSudoku())
            {
                return true;
            }
            tomb[cellToAdd.X, cellToAdd.Y] = tmpCell;
            return false;
        }

        public void FillAreas()
        {
            areas.Add("Area11", new Rectangle(0, 0, 3, 3));
            areas.Add("Area12", new Rectangle(0, 3, 3, 3));
            areas.Add("Area13", new Rectangle(0, 6, 3, 3));
            areas.Add("Area21", new Rectangle(3, 0, 3, 3));
            areas.Add("Area22", new Rectangle(3, 3, 3, 3));
            areas.Add("Area23", new Rectangle(3, 6, 3, 3));
            areas.Add("Area31", new Rectangle(6, 0, 3, 3));
            areas.Add("Area32", new Rectangle(6, 3, 3, 3));
            areas.Add("Area33", new Rectangle(6, 6, 3, 3));
        }

        public String InArea(int x, int y)
        {
            Point currentPoint = new Point(x, y);
            foreach (String AreaName in areas.Keys)
            {
                if (areas[AreaName].Contains(currentPoint)) {
                    return AreaName;
                }
            }
            return null;
        }

        public List<Cell> GetCellsInArea(String area)
        {
            List<Cell> returnList = new List<Cell>();
            for (int i = areas[area].X; i < areas[area].Right; i++)
            {
                for (int j = areas[area].Y; j < areas[area].Bottom; j++)
                {
                    returnList.Add(tomb[i, j]);
                }
            }
            return returnList;
        }

        public void Solve()
        {

        }

        bool CheckValidRow(Cell c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (tomb[i, c.Y].Value == c.Value)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckValidColumn(Cell c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (tomb[c.X, i].Value == c.Value)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckCompleteRow(int n)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                set.Add(tomb[i, n].Value);
            }
            if (set.Count == 9)
            {
                return true;
            }
            return false;
        }

        bool CheckCompleteColumn(int n)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i=0; i<9; i++)
            {
                set.Add(tomb[n, i].Value);
            }
            if (set.Count == 9)
            {
                return true;
            }
            return false;
        }

        bool CheckValidArea(Cell n)
        {
            String currentArea;
            currentArea = InArea(n.X, n.Y);
            List<Cell> cellsInArea = GetCellsInArea(currentArea);
            foreach (Cell cell in cellsInArea)
            {
                if(cell.Value == n.Value)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckCompleteArea(String area)
        {
            List<Cell> cellsInArea = GetCellsInArea(area);
            HashSet<int> set = new HashSet<int>();
            foreach (Cell currentCell in cellsInArea)
            {
                set.Add(currentCell.Value);
            }
            if (set.Count == 9)
            {
                return true;
            }
            return false;
        }

        bool CheckValidSudoku()
        {
            foreach(Cell cell in tomb)
            {
                if (CheckValidColumn(cell) && CheckValidRow(cell) && CheckValidArea(cell))
                {
                    return true;
                }
            }
            return false;
        }

        bool CheckCompleteSudoku()
        {
            foreach (String area in areas.Keys)
            {
                if (!CheckCompleteArea(area))
                {
                    return false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if(CheckCompleteColumn(i) && CheckCompleteRow(i))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
