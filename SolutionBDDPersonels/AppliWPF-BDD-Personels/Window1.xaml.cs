using BddpersonnelContext;
using biblioBDDPersonels1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
           

            foreach (Personnel personnel in personnels)
            {
                
                ListBoxTrom.Items.Add(stack(personnel));
               
            }

        }
        public void LoadImage(byte[] imageData, Image icon)
        {
            BitmapImage bitmapImage = new BitmapImage();

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = memoryStream;
                    bitmapImage.EndInit();
                }

                icon.Source = bitmapImage;
            }
            catch { }
        }
        public StackPanel stack(Personnel personnel)
        { 
            StackPanel stackPanel = new StackPanel();
            Image image = new Image();
            TextBlock textBlock = new TextBlock();
            LoadImage(personnel.Photo,image);
            textBlock.Text = personnel.Nom +" "+ personnel.Prenom;
            image.Width = image.Height = 150;
            textBlock.Width = 150;
            stackPanel.Width = 150;
            stackPanel.Children.Add(image);
            stackPanel.Children.Add(textBlock);
            return stackPanel;
        }

        private void BtAjouter_Click(object sender, RoutedEventArgs e)
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

        private void BtPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files |* .bmp;*.jpg;*.png";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                imagePicture.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void ListBoxTrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CBService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Service>services = new List<Service>();
            foreach (Service service in services)
            {
                CBService.Items.Add(service);
            }
        }
    }
}
