using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Паттер_Стретегия
{
    public interface ISwimBehavior
    {
        void Swim();
    }

    class NoSwim : ISwimBehavior
    {
        void ISwimBehavior.Swim()
        {
            MessageBox.Show("Не плавает :(");
        }
    }
    class CanSwim : ISwimBehavior
    {
        void ISwimBehavior.Swim()
        {
            MessageBox.Show("плавает :(");
        }
    }
}
