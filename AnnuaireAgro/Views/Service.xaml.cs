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
            // List<Models.Service> lst = Services.ServiceService.Instance.ChargerService();

          
        }


        private void new_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.ServiceViewModel vm = this.DataContext as ViewModels.ServiceViewModel;
            vm.NewService();

        }

  

     
  

        
    }
}