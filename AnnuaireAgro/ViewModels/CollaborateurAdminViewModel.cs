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
    class CollaborateurAdminViewModel : ViewModelBase
    {
        public ObservableCollection<Collaborateur> ListeCollaborateur { get; }

        //vue permettant de naviguer dans la liste des salariés (filtre, tri, sélection courante)
        private readonly ICollectionView collectionView;

        //l'element courant selectionne dans la vue
        public Collaborateur CollaborateurSelected
        {
            get
            {
                return collectionView.CurrentItem as Collaborateur;
            }
        }

        public CollaborateurAdminViewModel()
        {
            // récupère la liste brute du modèle
            List<Collaborateur> lst = Services.CollaborateurService.Instance.ChargerCollaborateur();

            //Initialise la liste observable
            ListeCollaborateur = new ObservableCollection<Collaborateur>();
            foreach (Collaborateur item in lst)
            {
                ListeCollaborateur.Add(item);
            }

            // définition de la collection view
            collectionView = CollectionViewSource.GetDefaultView(ListeCollaborateur);

            //declaration de l'evenement de changement de selection dans la vue
            collectionView.CurrentChanged += CollectionView_CurrentChanged;
        }

        protected void CollectionView_CurrentChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("CollaborateurSelected");
        }

        public void NewCollaborateur()
        {
            //créer le nouveau salarié
            Collaborateur newcollab = new Collaborateur();

            //l'ajouter à la liste
            ListeCollaborateur.Add(newcollab);
            //avertir la vue que la liste a changé
            NotifyPropertyChanged("ListeCollaborateur");
            //on se positionne sur le dernier élément créé dans la liste
            collectionView.MoveCurrentToLast();

        }

        // Commandes permettant de réaliser le CRUD
        private ICommand newCollaborateurCommand;
        public ICommand NewCollaborateurCommand
        {
            get
            {
                if (newCollaborateurCommand == null)
                {
                    newCollaborateurCommand = new RelayCommand(NewCollaborateur);
                }
                return NewCollaborateurCommand;
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
                        Services.CollaborateurService.Instance.Enregistrer(CollaborateurSelected);

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
                        Services.CollaborateurService.Instance.Supprimer(CollaborateurSelected);
                        //mettre à jour la liste !
                        ListeCollaborateur.Remove(CollaborateurSelected);
                        NotifyPropertyChanged("ListeCollaborateur");
                    });
                return deleteCommand;
            }
        }
    }
}
