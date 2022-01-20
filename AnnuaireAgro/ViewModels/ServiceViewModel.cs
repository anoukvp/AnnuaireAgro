using AnnuaireAgro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AnnuaireAgro.ViewModels
{
    class ServiceViewModel : ViewModelBase
    {

        public ObservableCollection<Service> ListeServices { get; }

        //vue permettant de naviguer dans la liste des contacts (filtre, tri, sélection courante)
        private readonly ICollectionView collectionView;

        //l'élément courant sélectionné dans la vue
        public Service ServiceSelected
        {
            get
            {
                return collectionView.CurrentItem as Service;
            }
        }

        public ServiceViewModel()
        {
            //recupère la liste brut du modèle
            List<Service> lst = Services.ServiceService.Instance.ChargerService();


            //initialise la liste observable
            ListeServices = new ObservableCollection<Service>();
            foreach (Service item in lst)
            {
                ListeServices.Add(item);
            }

            //définition de la collection view
            collectionView = CollectionViewSource.GetDefaultView(ListeServices);

            //déclarattion de l'événemt de changement de sélection dans la vue
            collectionView.CurrentChanged += CollectionView_CurrentChanged;
        }

        private void CollectionView_CurrentChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("ServiceSelected");
        }
    }
}
