using LibA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is MainA Application");
            var util = new Util();
            Console.WriteLine(util.Output());
            Console.ReadLine();
        }
    }
}
