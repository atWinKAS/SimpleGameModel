using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cgame = new Composition.Game();
            //cgame.Start();

            var igame = new Inheritance.Game();
            igame.Start();
             
            Console.ReadLine();
        }
    }
}
