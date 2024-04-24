using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Паттер_Стретегия 
{ 
    public interface IQuackBehavior
    {
        void quack();
    }
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.quack()
        {
            MessageBox.Show("Кря?...");
        }
    }

    class Squeack : IQuackBehavior
    {
        void IQuackBehavior.quack()
        {
            MessageBox.Show("Скрип?...Писк?...");
        }
    }

    class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.quack()
        {
            MessageBox.Show(".............");
        }
    }
}
