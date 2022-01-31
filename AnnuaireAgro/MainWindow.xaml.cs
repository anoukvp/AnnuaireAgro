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

namespace AnnuaireAgro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Services.ServiceService.Instance.Ensemencer();
            //Services.SiteService.Instance.Ensemencer();
           /// Services.CollaborateurService.Instance.saisirdonnees();

        }


        private void Sites_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Site();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Service();

        }

     
    

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift)
            {
               
                txtbAccueil.Visibility = Visibility.Hidden;
                logo.Visibility = Visibility.Hidden;
                btnCollab.Visibility = Visibility.Hidden;
                //Main.Content = new MainWindowAdmin();
                MainWindowAdmin w = new MainWindowAdmin();
                this.Hide();
                w.ShowDialog();
            }
        }

        private void btnCollab_Click(object sender, RoutedEventArgs e)
        {
            txtbAccueil.Visibility = Visibility.Hidden;
            logo.Visibility = Visibility.Hidden;
            btnCollab.Visibility = Visibility.Hidden;
            Main.Content = new Views.Collaborateur();
        }


    }
}
