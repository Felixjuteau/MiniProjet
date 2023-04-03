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
            CBServices();
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
            try
            {
                List<Personnel> personnels = bddPersonels.GetAllPersonnels();
                foreach (Personnel personnel in personnels)
                {

                    ListBoxTrom.Items.Add(stack(personnel));

                }
            }
            catch (Exception ex) { throw ex; }

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
            try
            {
                StackPanel stackPanel = new StackPanel();
                Image image = new Image();
                TextBlock textBlock = new TextBlock();
                image.Name = "I" + personnel.Id.ToString();
                textBlock.Name = "TB" + personnel.Id.ToString();
                LoadImage(personnel.Photo, image);
                textBlock.Text = "Nom: " + personnel.Nom + "\nPrénom: " + personnel.Prenom;
                textBlock.TextWrapping = TextWrapping.Wrap;
                textBlock.TextAlignment = TextAlignment.Center;
                image.Width = image.Height = 150;
                textBlock.Width = 150;
                stackPanel.Width = 150;
                stackPanel.Children.Add(image);
                stackPanel.Children.Add(textBlock);
                stackPanel.Name = "SP" + personnel.Id;
                return stackPanel;
            }
            catch (Exception ex) { throw ex; }
        }

        private void BtAjouter_Click(object sender, RoutedEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BtPhoto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Image files |* .bmp;*.jpg;*.png";
                openDialog.FilterIndex = 1;
                if (openDialog.ShowDialog() == true)
                {
                    imagePicture.Source = new BitmapImage(new Uri(openDialog.FileName));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ListBoxTrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try { 
            ListBox listBox = sender as ListBox;
            StackPanel selectedStackPanel = listBox.SelectedItem as StackPanel;
                if (selectedStackPanel != null)
                {
                    //je recupere l'image du stackpanel et je l'implante dans mon image de modif
                    Image selectedImage = selectedStackPanel.Children.OfType<Image>().FirstOrDefault();
                    imagePicture.Source = selectedImage.Source;

                    //je recupere le texte du textBlock
                    TextBlock selectedTextBlock = selectedStackPanel.Children.OfType<TextBlock>().FirstOrDefault();

                    //je recupere le nom
                    int found = selectedTextBlock.Text.IndexOf("\n");
                    string PP = selectedTextBlock.Text.Substring(found + 8).Trim();

                    String searchString = ":";
                    int startIndex = selectedTextBlock.Text.IndexOf(searchString) + 1;
                    searchString = "Prénom";
                    int endIndex = selectedTextBlock.Text.IndexOf(searchString) - 7;
                    String NP = selectedTextBlock.Text.Substring(startIndex, endIndex + searchString.Length - startIndex).Trim();
                    //MessageBox.Show(substring);
                    //MessageBox.Show(PP);
                    List<Personnel> personnels = bddPersonels.GetAllPersonnels();
                    if (personnels != null)
                    {
                        foreach (Personnel personnel in personnels)
                        {
                            if (NP == personnel.Nom && PP == personnel.Prenom)
                            {

                                TBNom.Text = personnel.Nom.ToString();
                                TBPrenom.Text = personnel.Prenom;
                                TBTelephone.Text = personnel.Telephone;
                                CBService.Text = personnel.Service.Intitule;
                                CBFonction.Text = personnel.Fonction.Intitule;
                                break;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("listPersonnel vide");
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CBServices()
        {
            try
            {
                List<Service> services = new List<Service>();
                foreach (Service service in services)
                {
                    CBService.Items.Add(service);
                    
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        private void BtModif_Click(object sender, RoutedEventArgs e)
        {
            Personnel personnel = CBService.SelectedItem as Personnel;
            if (TBNom.Text!=personnel.Nom && personnel.Nom!="" ||TBPrenom.Text!=personnel.Prenom && personnel.Prenom!=""||TBTelephone.Text!=personnel.Telephone||CBFonction.Text!=personnel.Fonction.ToString()||CBService.Text!=personnel.Service.ToString()|| )
            {
               
            }
        }
    }
}
