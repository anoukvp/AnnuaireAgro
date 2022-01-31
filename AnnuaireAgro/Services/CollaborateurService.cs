using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnuaireAgro.Models;

namespace AnnuaireAgro.Services
{
    class CollaborateurService
    {

        #region Singleton

        private static CollaborateurService instance;
        public static CollaborateurService Instance //propriété statique = au niveau de la classe
        {
            get
            {
                if (instance == null)
                {
                    instance = new CollaborateurService(); //auto instanciation la 1ère fois !
                }
                return instance;
            }
        }

        private CollaborateurService() //constructeur privé pour empecher une instanciation externe
        {

        }

        #endregion


        public List<Collaborateur> ChargerCollaborateur()
        {
            List<Collaborateur> lst = new List<Collaborateur>();

            using (AnnuaireContext context = new AnnuaireContext())
            {
                var lstCollaborateur = context.Collaborateur.ToList();
                lst.AddRange(lstCollaborateur);
            }
            return lst;
        }



        public Collaborateur Enregistrer(Collaborateur collaborateur)
        {

            using (AnnuaireContext context = new AnnuaireContext())

                if (collaborateur.Id == 0)
                {
                    //création
                    if (collaborateur.GetType() == typeof(Collaborateur))

                    {
                        context.Collaborateur.Add(collaborateur as Collaborateur);
                    }

                    else
                    // Update
                    {
                        context.Collaborateur.Update(collaborateur as Collaborateur);
                    }



                    context.SaveChanges();

                }



            return collaborateur;



        }

        public bool Supprimer(Collaborateur collaborateur)
        {

            using (AnnuaireContext context = new AnnuaireContext())
            {

                if (collaborateur.Id > 0)
                {
                    //Suppression
                    if (collaborateur.GetType() == typeof(Collaborateur))

                    {
                        context.Collaborateur.Remove(collaborateur as Collaborateur);
                    }

                    else

                    {
                      
                    }

                }

                context.SaveChanges();

                return true;

            }


        }

        public void saisirdonnees()
        {
            using (AnnuaireContext ctx = new AnnuaireContext())
            {
                ctx.Collaborateur.Add(new Collaborateur { Nom = "golade", Prenom = "larry", TelFixe = "0123454345", TelPortable = "0666578795", Email = "larry.golade@gmail.com", FK_idService =1 , FK_idSite = 1  });
                ctx.Collaborateur.Add(new Collaborateur { Nom = "dustriel", Prenom = "firmin", TelFixe = "0556678765", TelPortable = "0664345654", Email = "firmin.dustriel@gmail.com", FK_idService = 2, FK_idSite = 2 });
                ctx.Collaborateur.Add(new Collaborateur { Nom = "emoi", Prenom = "elise", TelFixe = "0445673456", TelPortable = "0668765432", Email = "elise.emoi@gmail.com", FK_idService = 3, FK_idSite = 2 });
                ctx.Collaborateur.Add(new Collaborateur { Nom = "chabat", Prenom = "alain", TelFixe = "0559867463", TelPortable = "0668976345", Email = "alain.chabat@gmail.com", FK_idService = 4, FK_idSite = 3 });
                ctx.SaveChanges();
            }
        }
    }
    }
