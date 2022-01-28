using AnnuaireAgro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace AnnuaireAgro.ViewModels
{
    class SiteViewModel : ViewModelBase
    {

        public ObservableCollection<Site> ListeSites { get; }

        //vue permettant de naviguer dans la liste des contacts (filtre, tri, sélection courante)
        private readonly ICollectionView collectionView;

        //l'élément courant sélectionné dans la vue
        public Site SiteSelected
        {
            get
            {
                return collectionView.CurrentItem as Site;
            }
        }


        public SiteViewModel()
        {
            //recupère la liste brut du modèle
            List<Site> lst = Services.SiteService.Instance.ChargerSite();

            //initialise la liste observable
            ListeSites = new ObservableCollection<Site>();
            foreach (Site item in lst)
            {
                ListeSites.Add(item);
            }

            //définition de la collection view
            collectionView = CollectionViewSource.GetDefaultView(ListeSites);

            //déclarattion de l'événemt de changement de sélection dans la vue
            collectionView.CurrentChanged += CollectionView_CurrentChanged;
        }

        private void CollectionView_CurrentChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("SiteSelected");
        }

        public void NewSite()
        {
            //créer le nouveau salarié
            Site newSite = new Site();

            //l'ajouter à la liste
            ListeSites.Add(newSite);
            //avertir la vue que la liste a changé
            NotifyPropertyChanged("ListeSites");
            //on se positionne sur le dernier élément créé dans la liste
            collectionView.MoveCurrentToLast();

        }

        // Différentes commandes qui vont nous servir pour le CRUD

        private ICommand newSiteCommand;
        public ICommand NewSiteCommand
        {
            get
            {
                if (newSiteCommand == null)
                {
                    newSiteCommand = new RelayCommand(NewSite);
                }
                return NewSiteCommand;
            }
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new RelayCommand(() =>
                    {
                        Services.SiteService.Instance.Enregistrer(SiteSelected);

                    });
                return saveCommand;
            }

        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                    deleteCommand = new RelayCommand(() =>
                    {
                        Services.SiteService.Instance.Supprimer(SiteSelected);
                        //mettre à jour la liste !
                        ListeSites.Remove(SiteSelected);
                        NotifyPropertyChanged("ListeSites");
                    });
                return deleteCommand;
            }
        }

    }
}
