using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public string _p1 { set; get; }

        public Class1()
        {
            this._p1 = "Clase 1";
        }
        public virtual void M1()
        {
            Console.WriteLine("Clase 1");
        }

    }
}

