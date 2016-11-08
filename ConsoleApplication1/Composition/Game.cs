using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Composition
{
    class Game
    {
        public void Start()
        {
            var tank = new BattleTank();
            tank.Shooter = new BaseShooter();
            tank.Mover = new TankMover();
            tank.Move();
            tank.Shoot();

            var plane = new BattlePlane();
            plane.Shooter = new BaseShooter();
            plane.Mover = new PlaneMover();
            plane.Move();
            plane.Shoot();

            var enTank = new IngeneeringTank();
            enTank.Mover = new TankMover();
            enTank.Move();

            var trPlane = new TransportPlane();
            trPlane.Mover = new PlaneMover();
            trPlane.Move();

            var tower = new Tower();
            tower.Shooter = new TowerShooter();
            tower.Shoot();
        }
    }

    public interface IShooter
    {
        void Shoot();
    }

    public interface IMover
    {
        void Move();
    }

    public class BaseShooter : IShooter
    {
        public void Shoot()
        {
            Console.WriteLine("Base Shoot");

        }
    }

    public class TowerShooter : IShooter
    {
        public void Shoot()
        {
            Console.WriteLine("Tower Shoot");

        }
    }

    public class TankMover : IMover
    {
        public void Move()
        {
            Console.WriteLine("Tank Move");
        }
    }

    public class PlaneMover : IMover
    {
        public void Move()
        {
            Console.WriteLine("Plane Move");
        }
    }

    public interface IGameObject
    {
        //void WriteName();
        
    }

    public interface IMovable
    {
        void Move();
    }

    public interface IShootable
    {
        void Shoot();
    }

    public class BattleTank : IGameObject, IMovable, IShootable
    {
        public IShooter Shooter { get; set; }
        public IMover Mover { get; set; }

        public void Move()
        {
            this.Mover.Move();
        }

        public void Shoot()
        {
            this.Shooter.Shoot();
        }
    }

    public class BattlePlane : IGameObject, IMovable, IShootable
    {
        public IShooter Shooter { get; set; }
        public IMover Mover { get; set; }

        public void Move()
        {
            this.Mover.Move();
        }

        public void Shoot()
        {
            this.Shooter.Shoot();
        }
    }

    public class IngeneeringTank : IGameObject, IMovable
    {
        public IMover Mover { get; set; }

        public void Move()
        {
            this.Mover.Move();
        }
    }

    public class TransportPlane : IGameObject, IMovable
    {
        public IMover Mover { get; set; }

        public void Move()
        {
            this.Mover.Move();
        }
    }

    public class Tower : IGameObject, IShootable
    {
        public IShooter Shooter { get; set; }

        public void Shoot()
        {
            this.Shooter.Shoot();
        }
    }
}
