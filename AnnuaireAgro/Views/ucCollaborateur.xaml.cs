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
    /// Logique d'interaction pour ucCollaborateur.xaml
    /// </summary>
    public partial class ucCollaborateur : UserControl
    {
        public ucCollaborateur()
        {
            InitializeComponent();
            RemplirTxtSite();
        }

        private void RemplirTxtSite()
        {

            var cnn = new AnnuaireContext();

            //var value = Convert.ToInt32();

            var res = (from c in cnn.Collaborateur
                       join s in cnn.Service on c.FK_idService equals s.Id
                       join si in cnn.Site on c.FK_idSite equals si.Id
                       //where c.Id == value
                       select s.Nom ).FirstOrDefault();

            txtSite.Text = res;


        }

    }
}
