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
    public partial class Tasker : Form
    {
        public Tasker()
        {
            InitializeComponent();
        }
        private void UpdateProcessList()

        {

            // clear the existing list of any items

            listBox1.Items.Clear();

            // loop through the running processes and add

            //each to the list

            foreach (System.Diagnostics.Process p in

            System.Diagnostics.Process.GetProcesses())

            {

                listBox1.Items.Add(p.ProcessName + " - " + p.Id);

            }

            // display the number of running processes in

            // a status message at the bottom of the page

            label1.Text = "Processes running: " +

            listBox1.Items.Count.ToString();

        }


        private void TaskMgr_Load(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // loop through the running processes looking for a match

            // by comparing process name to the name selected in the listbox

            foreach (System.Diagnostics.Process p in

            System.Diagnostics.Process.GetProcesses())

            {

                string[] arr = listBox1.SelectedItem.ToString().Split('-');

                string sProcess = arr[0].Trim();

                int iId = Convert.ToInt32(arr[1].Trim());

                if (p.ProcessName == sProcess && p.Id == iId)

                {

                    p.Kill();

                }

            }

            UpdateProcessList();
        }
    }
}
