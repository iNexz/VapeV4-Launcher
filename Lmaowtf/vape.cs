using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lmaowtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            siticonePanel3.Width += 1;

            if (siticonePanel3.Width == 2)
            {
                if (Process.GetProcessesByName("javaw").Length == 0)
                {
                    siticonePanel1.Hide(); //closed
                    label1.Visible = true;
                    timer1.Stop();
                    return;
                }
            }
            else
            {
                if (siticonePanel3.Width == 295)
                {
                    timer2.Start();
                    this.Hide();
                    timer1.Stop();
                }
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Process[] workers = Process.GetProcessesByName("javaw");
            foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
            }
        }
    }
}
