using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_CA
{
    public class Drawer
    {
        public static float Width { get; set; }
        public static float SideOfSquare { get; set; }

        public static void CreateChessField(Graphics graphics)
        {
            float val = 40;
            Width = 400;
            Brush brush = new SolidBrush(Color.Brown);
            graphics.Clear(SystemColors.Control);
            float X = val;
            float Y = val;
            SideOfSquare = val;
            for (int i = 0; i < 8; i++)
            {
                X = val;
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                        graphics.FillRectangle(brush, X, Y, SideOfSquare, SideOfSquare);
                    X += val;
                }
                Y += val;
            }
        }

        public static void PrintLvl(Graphics graphics, int X, int Y, int Num)
        {
            float x = SideOfSquare + SideOfSquare * X + SideOfSquare / 2;
            float y = SideOfSquare + SideOfSquare * Y + SideOfSquare / 2;
            Brush brush = new SolidBrush(Color.Black);
            graphics.DrawString(Num.ToString(), new Font(FontFamily.GenericSerif, 12), brush, x, y);
        }
    }
}
