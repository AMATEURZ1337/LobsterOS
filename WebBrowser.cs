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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.com");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
