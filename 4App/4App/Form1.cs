using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4App
{
    public partial class Form1 : Form
    {
        private string[] files;
        public int gijuKiekis;
        public Form1()
        {
            InitializeComponent();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gijuKiekis = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = true;
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = folder.SelectedPath;
                Environment.SpecialFolder root = folder.RootFolder;
                string filename = Directory.GetFiles(textBox2.Text).First();
                files = Directory.GetFiles(textBox2.Text);
                MessageBox.Show(Convert.ToString(files.Length));
            }
            int a = 0;
            for (int i = 1; i < Convert.ToInt32(textBox1.Text)+1; i++)
            {
                Slave r2d2 = new Slave();
                for (int b = 0; b < 10*i; b++)
                {
                    b = a;
                    r2d2.Files.Add(files[b]);
                    r2d2.Start();
                    a++;
                }
            }
        }
    }
}
