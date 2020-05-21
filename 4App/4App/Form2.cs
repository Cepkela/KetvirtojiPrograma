using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            int kiekis = fr1.gijuKiekis;
            progressBar1.Value = kiekis;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i<=100; i++)
            {
                if(backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    simulateHeavyJob();
                    backgroundWorker1.ReportProgress(i);
                }
            }
        }
        private void simulateHeavyJob()
        {

        }
    }
}
