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
   public class ServiceViewModel : ViewModelBase
    {


        public ObservableCollection<Service> ListeService { get; }

        //vue permettant de naviguer dans la liste des fonctions (filtre, tri, sélection courante)
        private readonly ICollectionView collectionView;

        //l'element courant selectionne dans la vue
        public Service ServiceSelected
        {
            get
            {
                return collectionView.CurrentItem as Service;
            }
        }

        public ServiceViewModel()
        {
            // récupère la liste brute du modèle
            List<Service> lst = Services.ServiceService.Instance.ChargerService();

            //Initialise la liste observable
            ListeService = new ObservableCollection<Service>();
            foreach (Service item in lst)
            {
                ListeService.Add(item);
            }

            // définition de la collection view
            collectionView = CollectionViewSource.GetDefaultView(ListeService);

            //declaration de l'evenement de changement de selection dans la vue
            collectionView.CurrentChanged += CollectionView_CurrentChanged;
        }

        protected void CollectionView_CurrentChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("ServiceSelected");
        }

        public void NewService()
        {
            //créer la nouevelle fonction
            Service newService = new Service();

            //l'ajouter à la liste
            ListeService.Add(newService);
            //avertir la vue que la liste a changé
            NotifyPropertyChanged("ListeService");
            //on se positionne sur le dernier élément créé dans la liste
            collectionView.MoveCurrentToLast();

        }
        private ICommand newServiceCommand;
        public ICommand NewServiceCommand
        {
            get
            {
                if (newServiceCommand == null)
                {
                    newServiceCommand = new RelayCommand(NewService);
                }
                return NewServiceCommand;
            }
        }

        private ICommand saveCommand; //propfull tab tab (plus détaillé que prop tab tab quand on veut modifier le get

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new RelayCommand(() =>
                    {
                        Services.ServiceService.Instance.Enregistrer(ServiceSelected);

                    });
                return saveCommand;
            }

        }

        private ICommand deleteCommand; //propfull tab tab (plus détaillé que prop tab tab quand on veut modifier le get

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                    deleteCommand = new RelayCommand(() =>
                    {
                        Services.ServiceService.Instance.Supprimer(ServiceSelected);
                            //mettre à jour la liste !
                            ListeService.Remove(ServiceSelected);
                        NotifyPropertyChanged("ListeService");
                    });
                return deleteCommand;
            }
        }
    }
    }
