using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _4App
{
    public class Slave
    {
        public List<string> Files = new List<string>();
        private Thread runner;
        public void Start()
        { // the usual place to start threads
            if (runner == null)
            {
                runner = new Thread(Run);
                runner.Start();
            }
        }
        public void Run()
        {
            StreamWriter sw = new StreamWriter("rez.txt");
            foreach (var item in Files)
            {
                sw.WriteLine(item);
            }
        }
        public Slave()
        {

        }
    }
}
