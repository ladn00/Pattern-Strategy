using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Паттер_Стретегия
{
    abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        public ISwimBehavior SwimBehavior { get; set; }

        public virtual void Display()
        {
            PerformQuack();
            PerformFly();
            PerfromSwim();
        }
        public void PerformQuack()
        {
            QuackBehavior.quack();
        }
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerfromSwim()
        {
            SwimBehavior.Swim();
        }
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.FlyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.QuackBehavior = quackBehavior;
        }
        public void SetSwimBehavior(ISwimBehavior swimBehavior)
        {
            this.SwimBehavior = swimBehavior;
        }
    }

    class MallarDuck : Duck
    {
        public MallarDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
            SwimBehavior = new CanSwim();
        }
        public override void Display()
        {
            MessageBox.Show("Кряква...");
            base.Display();
        }
    }

    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
            SwimBehavior = new CanSwim();
        }
        public override void Display()
        {
            MessageBox.Show("Красная шапочка...Почти как у В.В.");
            base.Display();
        }
    }

    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeack();
            SwimBehavior = new CanSwim();
        }
        public override void Display()
        {
            MessageBox.Show("Резиновая уточка");
            base.Display();
        }
    }

    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
            SwimBehavior = new CanSwim();
        }
        public override void Display()
        {
            MessageBox.Show("Утка-приманка на голодного студента");
            base.Display();
        }
    }
    class MedicineDuck : Duck
    {
        public MedicineDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
            SwimBehavior = new NoSwim();
        }
        public override void Display()
        {
            MessageBox.Show("Медицинская утка");
            base.Display();
        }
    }
}
