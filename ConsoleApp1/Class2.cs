using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2 : Class1
    {
        public string _p1 { set; get; }

        public Class2()
        {
            this._p1 = "Clase 2";
        }
        public override void M1()
        {
            Console.WriteLine("Clase 2");
        }

    }
}
