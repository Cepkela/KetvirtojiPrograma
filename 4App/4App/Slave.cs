using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4App
{
    public class Slave
    {
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
            Console.WriteLine("i");
        }
    }
}
