using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_CA
{
    public partial class MainForm : Form
    {
        public bool run = false;
        public bool modified = false;
        public static System.Drawing.Graphics graphicsObj;
        public MainForm()
        {
            InitializeComponent();
            graphicsObj  = this.CreateGraphics();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (run)
                return;
            if (modified)
                Drawer.CreateChessField(graphicsObj);
            run = true;
            int X = e.X;
            int Y = e.Y;
            if (X < Drawer.SideOfSquare || X > Drawer.Width - Drawer.SideOfSquare 
                || Y < Drawer.SideOfSquare || Y > Drawer.Width - Drawer.SideOfSquare)
                return;
            X -= (int)Drawer.SideOfSquare;
            Y -= (int)Drawer.SideOfSquare;
            X = (int)(X / Drawer.SideOfSquare);
            Y = (int)(Y / Drawer.SideOfSquare);
            Algorithm.Initialize(X, Y);
            Drawer.PrintLvl(graphicsObj, X, Y, 0);
            while (Algorithm.DrawNextLvl(ref graphicsObj))
            {
                Thread.Sleep(1300);
            }
            Algorithm.ClearMtx();
            modified = true;
            run = false;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Drawer.CreateChessField(graphicsObj);
            modified = false;
        }
    }
}
