using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Inheritance
{
    internal class Game
    {
        public void Start()
        {
            var tank = new Tank();
            tank.DoMove();
            tank.DoShooting();

            var plane = new Plane();
            plane.DoMove();
            plane.DoShooting();
        }

        public abstract class BaseEntity
        {
            public void DoShooting()
            {
                Console.WriteLine("Do shoot");
            }
        
            public abstract void DoMove();
        }


        public class Plane : BaseEntity
        {
            public override void DoMove()
            {
                Console.WriteLine("Plane move");
            }
        }


        public class Tank : BaseEntity
        {
            public override void DoMove()
            {
                
                Console.WriteLine("Tank move");
            }
        }
    }
}
