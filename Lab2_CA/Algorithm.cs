using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_CA
{
    class Algorithm
    {
        public static int[,] matrix = new int[8, 8];
        public static int lvl { get; set; }

        public static void ClearMtx()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = -1;
                }
            }
        }

        public static void Initialize(int X,int Y)
        {
            ClearMtx();
            matrix[X, Y] = 0;
            lvl = 0;
        }

        public static List<Point> GetNextPoints(int X, int Y)
        {
            List<Point> result = new List<Point>();
            //перемещения по X
            for (int i=0; i<8; i++)
            {
                if ((matrix[i, Y] < 0)&&(i!=X))
                    result.Add(new Point(i, Y));
            }
            //перемещения по Y
            for (int i = 0; i < 8; i++)
            {
                if ((matrix[X, i] < 0) && (i != Y))
                    result.Add(new Point(X, i));
            }
            return result;
        }

        public static bool DrawNextLvl(ref Graphics graphics_in)
        {
            List<Point> pts = new List<Point>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == lvl)
                    {
                        pts.AddRange(GetNextPoints(i, j));
                    }
                }
            }
            if (pts.Count == 0)
                return false;
            ++lvl;
            foreach (var point in pts)
            {
                matrix[point.X, point.Y] = lvl;
                //тут будет вызываться метод отрисовки
            }
            return true;
        }
    }
}
