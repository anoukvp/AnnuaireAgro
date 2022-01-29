﻿using System;
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
    /// Logique d'interaction pour Site.xaml
    /// </summary>
    public partial class Site : Page
    {
        public Site()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.SiteViewModel();
            List<Models.Site> lst = Services.SiteService.Instance.ChargerSite();

        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.SiteViewModel vm = this.DataContext as ViewModels.SiteViewModel;
            vm.NewSite();

        }
    }
}
