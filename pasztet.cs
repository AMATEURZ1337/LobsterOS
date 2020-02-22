using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LobsterOSOfficial
{
    public partial class pasztet : Form
    {
        public pasztet()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Paint_MouseMove);
            this.MouseUp += new MouseEventHandler(Paint_MouseUp);
            this.MouseDown += new MouseEventHandler(Paint_MouseDown);
        }
        bool drw;
        int beginX, beginY;

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.White, 4);
            Point point1 = new Point(beginX, beginY);
            Point point2 = new Point(e.X, e.Y);
            if (drw == true)
            {
                g.DrawLine(p, point1, point2);
                beginX = e.X;
                beginY = e.Y;
            }
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            this.Text = "LobsterOS || Paint";
            this.BackColor = Color.Black;
        }
    }
}
