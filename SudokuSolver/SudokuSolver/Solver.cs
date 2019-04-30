using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuSolver
{
    class Solver
    {
        Cell[,] tomb;
        Dictionary<String, Rectangle> areas;

        public Solver()
        {
            tomb = new Cell[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.tomb[i, j] = new Cell(0, i, j);
                }
            }
            areas = new Dictionary<string, Rectangle>();
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
                if (areas[AreaName].Contains(currentPoint))
                {
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
            foreach (Cell actualCell in tomb)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (actualCell.Value != i)
                    {
                        actualCell.AddPossibleNum(i);
                    }
                }
            }

            foreach (Cell actualCell in tomb)
            {
                if (actualCell.Value != 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        tomb[actualCell.X, i].RemovePossibleNum(actualCell.Value);
                        tomb[i, actualCell.Y].RemovePossibleNum(actualCell.Value);
                        GetCellsInArea(InArea(actualCell.X, actualCell.Y));
                    }
                }
            }

            StreamWriter output = new StreamWriter("csolve.csv", false);
            foreach (Cell actualCell in tomb)
            {
                if (actualCell.Value != 0)
                {
                    valueAdded(actualCell);
                    output.WriteLine(actualCell.X + ";" + actualCell.Y + ";" + actualCell.Value);
                }
            }

            output.WriteLine("defaultEnds");

            while (!CheckCompleteSudoku())
            {
                for (int i = 0; i < 9; i++)
                {
                    for(int j = 0; j<9; j++)
                    {
                        Cell current = tomb[i, j];
                        int added = 0;
                        if (current.GetPossibleLength() == 1)
                        {
                            current.Value = current.PossibleNums.Single();

                            added = current.PossibleNums.Single();
                            valueAdded(tomb[i, j]);
                            output.WriteLine(tomb[i, j].X + ";" + tomb[i, j].Y + ";" + tomb[i, j].Value);
                        }
                    }
                }
            }
        }

        bool CheckValidRow(Cell c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != c.X)
                {
                    if (tomb[i, c.Y].Value == c.Value && tomb[i, c.Y].Value != 0 && c.Value != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        bool CheckValidColumn(Cell c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != c.Y)
                {
                    if (tomb[c.X, i].Value == c.Value && tomb[c.X, i].Value != 0 && c.Value != 0)
                    {
                        return false;
                    }
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
            for (int i = 0; i < 9; i++)
            {
                set.Add(tomb[n, i].Value);
            }
            if (set.Count == 9)
            {
                return true;
            }
            return false;
        }

        bool CheckValidArea(Cell cell)
        {
            String currentArea;
            currentArea = InArea(cell.X, cell.Y);
            List<Cell> cellsInArea = GetCellsInArea(currentArea);
            foreach (Cell tmpCell in cellsInArea)
            {
                if (cell.X != tmpCell.X && cell.Y != tmpCell.Y) {
                    if (tmpCell.Value == cell.Value && tmpCell.Value != 0 && cell.Value != 0)
                    {
                        return false;
                    }
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
            foreach (Cell cell in tomb)
            {
                if (!CheckValidColumn(cell) || !CheckValidRow(cell) || !CheckValidArea(cell))
                {
                    return false;
                }
            }
            return true;
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
                if (!CheckCompleteColumn(i) || !CheckCompleteRow(i))
                {
                    return false;
                }
            }
            return true;
        }

        void valueAdded(Cell c)
        {
            for(int i=0; i<9; i++)
            {
                tomb[c.X, i].RemovePossibleNum(c.Value);
                tomb[i, c.Y].RemovePossibleNum(c.Value);
            }
            List<Cell> currentArea = GetCellsInArea(InArea(c.X, c.Y));
            foreach(Cell current in currentArea)
            {
                current.RemovePossibleNum(c.Value);
            }
        }
    }
}
