using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Паттер_Стретегия
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Duck> list = new List<Duck>();

            list.Add(new RedHeadDuck());
            list.Add(new MedicineDuck());
            list.Add(new RubberDuck());

            foreach(Duck d in list)
            {
                d.Display();
            }
        }
    }
}
