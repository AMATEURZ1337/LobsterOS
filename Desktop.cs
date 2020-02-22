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
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();

        }

        private void DateLabel()
        {
            label1.Text = DateTime.Now.ToString();
        }
        /*
            Form f = new Form();
            f.TopLevel = false;
            f.Parent = this;  
            f.Show();
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLabel();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MeniSart ssztasr = new MeniSart();
            ssztasr.TopLevel = false;
            ssztasr.Parent = this;
            ssztasr.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pasztet f = new pasztet();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Notepad Notatnik = new Notepad();
            Notatnik.TopLevel = false;
            Notatnik.Parent = this;
            Notatnik.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Tasker RaskManager = new Tasker();
            RaskManager.TopLevel = false;
            RaskManager.Parent = this;
            RaskManager.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            WebBrowser InternetBrowser = new WebBrowser();
            InternetBrowser.TopLevel = false;
            InternetBrowser.Parent = this;
            InternetBrowser.Show();
        }
    }
}
