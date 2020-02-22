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
    public partial class MeniSart : Form
    {
        public MeniSart()
        {
            InitializeComponent();
        }

        private void showShit()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string ProcessorName = System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            label2.Text = userName;
            label4.Text = ProcessorName;
        }
        private void MeniSart_Load(object sender, EventArgs e)
        {
            showShit();
        }
    }
}
