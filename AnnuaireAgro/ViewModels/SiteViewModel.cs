//using AnnuaireAgro.Models;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnnuaireAgro.ViewModels
//{
//    class SiteViewModel : ViewModelBase
//    {

//        public ObservableCollection<Site> ListeContacts { get; }

//        //vue permettant de naviguer dans la liste des contacts (filtre, tri, sélection courante)
//        private readonly ICollectionView collectionView;

//        //l'élément courant sélectionné dans la vue
//        public Contact ContactSelected
//        {
//            get
//            {
//                return collectionView.CurrentItem as Contact;
//            }
//        }


//        public ListeViewModel()
//        {
//            //recupère la liste brut du modèle
//            List<Contact> lst = Services.ContactsService.Instance.ChargerContacts();

//            //initialise la liste observable
//            ListeContacts = new ObservableCollection<Contact>();
//            foreach (Contact item in lst)
//            {
//                ListeContacts.Add(item);
//            }

//            //définition de la collection view
//            collectionView = CollectionViewSource.GetDefaultView(ListeContacts);

//            //déclarattion de l'événemt de changement de sélection dans la vue
//            collectionView.CurrentChanged += CollectionView_CurrentChanged;
//        }

//        private void CollectionView_CurrentChanged(object sender, EventArgs e)
//        {
//            NotifyPropertyChanged("ContactSelected");
//        }

//        public void NewClient()
//        {
//            //créer le nouveau client
//            Client newcli = new Client();
//            //l'ajouter à la liste
//            ListeContacts.Add(newcli);
//            //avertit la vue que la liste a changé
//            NotifyPropertyChanged("ListeContacts");
//            //se positionne sur le dernier élément créé dans la liste
//            collectionView.MoveCurrentToLast();
//        }

//        private ICommand newAmiCommand;
//        public ICommand NewAmiCommand
//        {
//            get
//            {
//                if (newAmiCommand == null)
//                {
//                    newAmiCommand = new RelayCommand(NewAmi);
//                }
//                return newAmiCommand;
//            }
//        }

//        public void NewAmi()
//        {
//            //créer le nouveau ami
//            Ami newcli = new Ami();
//            //l'ajouter à la liste
//            ListeContacts.Add(newcli);
//            //avertit la vue que la liste a changé
//            NotifyPropertyChanged("ListeContacts");
//            //se positionne sur le dernier élément créé dans la liste
//            collectionView.MoveCurrentToLast();
//        }



//        private ICommand saveCommand;
//        public ICommand SaveCommand
//        {
//            get
//            {
//                if (saveCommand == null)
//                    saveCommand = new RelayCommand(() =>
//                    {
//                        Services.ContactsService.Instance.Enregistrer(ContactSelected);
//                    });
//                return saveCommand;
//            }
//        }

//        private ICommand deleteCommand;
//        public ICommand DeleteCommand
//        {
//            get
//            {
//                if (deleteCommand == null)
//                    deleteCommand = new RelayCommand(() =>
//                    {
//                        Services.ContactsService.Instance.Supprimer(ContactSelected);
//                        //mettre à jour la liste !
//                        ListeContacts.Remove(ContactSelected);
//                        NotifyPropertyChanged("ListeContacts");
//                    });
//                return deleteCommand;
//            }
//        }

//    }
//}
