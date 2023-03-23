using BddpersonnelContext;
using biblioBDDPersonels1;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    { 
          private CBDDPersonels1 bddPersonels = null;
    public Window1()
        {
            InitializeComponent();
            bddPersonels = new CBDDPersonels1();
            Trombinoscope();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files |* .bmp;*.jpg;*.png";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                imagePicture.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void Button_envoyer(object sender, RoutedEventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel.Nom = TBNom.Text.ToString();
            personnel.Prenom = TBPrenom.Text.ToString();
            //recuperer image et la mettre dans le personnel
            List<Service> services = bddPersonels.GetAllServices();
            List<Fonction> fonctions = bddPersonels.GetAllFonction();
            foreach (Service service in services)
            {
                if (CBService.Text == service.Intitule)
                {
                    personnel.Service = service;
                    personnel.IdService = service.Id;
                }
            }
            foreach (Fonction fonction in fonctions)
            {
                if (CBFonction.Text == fonction.Intitule)
                {
                    personnel.Fonction = fonction;
                    personnel.IdFonction = fonction.Id;
                }
            }
        }
        private void Trombinoscope()
        {
            List<Personnel> personnels = bddPersonels.GetAllPersonnels();
            BitmapImage image = new BitmapImage();
            foreach (Personnel personnel in personnels)
            {
                image.BeginInit();
                image.UriSource=new bi
                image.EndInit();
                UnPersonelImg.Source= image;
                UnPersonelTB.Text = personnel.Nom + personnel.Prenom;
                ListBoxTrom.Items.Add(UnPersonel);
                
            }

        }


       
    }
}
