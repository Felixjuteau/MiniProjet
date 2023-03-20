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
using BddpersonnelContext;
using biblioBDDPersonels1;


namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CBDDPersonels1 bddPersonels=null;
        public MainWindow()
        {
            InitializeComponent();
            bddPersonels= new CBDDPersonels1();
            List<Service> services=bddPersonels.GetAllServices();
            datagridServies.ItemsSource = services;
        }
    }
}
