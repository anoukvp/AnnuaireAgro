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
using AnnuaireAgro.Models;

namespace AnnuaireAgro.Views
{
    /// <summary>
    /// Logique d'interaction pour Collaborateur.xaml
    /// </summary>
    public partial class Collaborateur : Page
    {
        public Collaborateur()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.CollaborateurViewModel();
            List<Models.Collaborateur> lst = Services.CollaborateurService.Instance.ChargerCollaborateur();

        }

        private void accueil_Click(object sender, RoutedEventArgs e)
        {
            MainWindow accueil = new MainWindow();
           
            accueil.Show();
        }
    }
}
