using AnnuaireAgro.Models;
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

namespace AnnuaireAgro.Views
{
    /// <summary>
    /// Logique d'interaction pour Service.xaml
    /// </summary>
    public partial class Service : Page
    {
        public Service()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.ServiceViewModel();
            remplirServices();

        }

        private void remplirServices()
        {
            var cnn = new AnnuaireContext();
            var value = Convert.ToInt32(ListeServices.SelectedValue);

            ListeServices.ItemsSource = (from s in cnn.Service
                                         select new {s.Id, s.Nom }).ToList();
        }

        private void ListeServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // requeteServices();
        }

        //private void requeteServices()
        //{
        //    var cnn = new AnnuaireContext();

        //    var req = (from c in cnn.Collaborateur
        //               join s in cnn.Service on c.FK_idService equals s.Id
        //               where c.FK_idService == Convert.ToInt32(ListeServices.SelectedValue)
        //               select new
        //               {
        //                   Id = c.Id,
        //                   Nom = c.Nom,
        //                   Prenom = c.Prenom
        //               });



        //    ListeServicesassoc.ItemsSource = new BindingListCollectionView<Collaborateur>(req.ToList());


        //}
    }
}