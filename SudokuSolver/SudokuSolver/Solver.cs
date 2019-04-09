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


        public Solver(int[,] tomb)
        {
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    this.tomb[i,j] = new Cell(tomb[i, j]);
                }
            }
            fillAreas();
        }

        public void fillAreas()
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

        public String inArea(Cell actualCell)
        {

        }

        public List<Cell> getCellsInArea(String area)
        {
            List<Cell> returnList = new List<Cell>();
            for(int i=areas[area].X; i<areas[area].Right; i++)
            {
                for (i = areas[area].Y; i < areas[area].Bottom; i++)
                {
                    returnList.Add(tomb[i, j]);
                }
            }
            return returnList;
        }

        void Solve()
        {

        }

        bool checkRow(int n)
        {
            
        }

        bool checkColumn(int n)
        {

        }
    }
}
