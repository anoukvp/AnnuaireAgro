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
    /// Logique d'interaction pour CollaborateurAdmin.xaml
    /// </summary>
    public partial class CollaborateurAdmin : Page
    {
        public CollaborateurAdmin()
        {
            InitializeComponent();
        }

        private void newCollab_Click(object sender, RoutedEventArgs e)
        {

            ViewModels.CollaborateurAdminViewModel vm = this.DataContext as ViewModels.CollaborateurAdminViewModel;
            vm.NewCollaborateur();


        }
    }
}
