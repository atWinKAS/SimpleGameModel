using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Composition;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Start();
            Console.ReadLine();
        }
    }
}
