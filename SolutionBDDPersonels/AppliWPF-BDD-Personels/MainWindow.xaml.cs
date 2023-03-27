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
using Microsoft.Win32;

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
            List<Personnel> services = bddPersonels.GetAllPersonnels();
            datagridServices.ItemsSource = services;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           OpenFileDialog openDialog= new OpenFileDialog();
            openDialog.Filter = "Image files |* .bmp;*.jpg;*.png";
            openDialog.FilterIndex = 1;
            if(openDialog.ShowDialog()==true)
            {
                imagePicture.Source=new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void Button_envoyer(object sender, RoutedEventArgs e)
        {
            Window1 test=new Window1();
            test.ShowDialog();
            //Personnel personnel = new Personnel();
            //personnel.Nom=TBNom.Text.ToString();
            //personnel.Prenom=TBPrenom.Text.ToString();
            //List<Service> services = bddPersonels.GetAllServices();
            //List<Fonction> fonctions=bddPersonels.GetAllFonction();
            //foreach(Service service in services)
            //{
            //    if (TBService.Text == service.Intitule)
            //    {
            //        personnel.Service=service;
            //        personnel.IdService = service.Id;
            //    }
            //}
            //foreach(Fonction fonction in fonctions )
            //{
            //    if(TBFonction.Text==fonction.Intitule)
            //    {
            //        personnel.Fonction=fonction;
            //        personnel.IdFonction=fonction.Id;
            //    }
            //}
        }
    }
}
