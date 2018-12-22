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
        public static Graphics chessField;
        public MainForm()
        {
            InitializeComponent();
            chessField = this.CreateGraphics();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
