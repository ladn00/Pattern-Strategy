using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace Паттер_Стретегия
{
    public interface IFlyBehavior
    {
        void Fly();
    }
    class FlyWithWings : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            MessageBox.Show("Полет ура-ура. Куда летим?");
        }
    }

    class FlyNoWay : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            MessageBox.Show("Fly No Way?! Нет Путя?!");
        }
    }
}
