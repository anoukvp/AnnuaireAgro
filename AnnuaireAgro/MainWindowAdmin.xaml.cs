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

namespace AnnuaireAgro
{
    /// <summary>
    /// Logique d'interaction pour MainWindowAdmin.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        public MainWindowAdmin()
        {
            InitializeComponent();
        }
        private void Collaborateur_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Collaborateur();
        }
        private void Sites_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Site();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Service();

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow accueil = new MainWindow();
            this.Hide();
            accueil.Show();
        }
    }
}
