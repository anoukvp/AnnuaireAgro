using AnnuaireAgro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Services
{
    public class ServiceService
    {
        #region Singleton

        private static ServiceService instance;
        public static ServiceService Instance //propriété statique = au niveau de la classe
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceService(); //auto instanciation la 1ère fois !
                }
                return instance;
            }
        }

        private ServiceService() //constructeur privé pour empecher une instanciation externe
        {

        }

        #endregion


        public List<Service> ChargerService()
        {
            List<Service> lst = new List<Service>();

            using (AnnuaireContext context = new AnnuaireContext())
            {
                var lstServices = context.Service.ToList();
                lst.AddRange(lstServices);

            }

            return lst;
        }

        public Service Enregistrer(Service service)
        {

            using (AnnuaireContext context = new AnnuaireContext())

                if (service.Id == 0)
                {
                    //création
                    if (service.GetType() == typeof(Service))

                    {
                        context.Service.Add(service as Service);
                    }

                    else

                    {
                        context.Service.Update(service as Service);
                    }

                    context.SaveChanges();

                }



            return service;



        }

        public bool Supprimer(Service service)
        {

            using (AnnuaireContext context = new AnnuaireContext())
            {

                if (service.Id > 0)
                {
                    //Suppression
                    if (service.GetType() == typeof(Service))

                    {
                        context.Service.Remove(service as Service);
                    }

                    else

                    {

                    }

                }

                context.SaveChanges();

                return true;

            }


        }


        public void Ensemencer()
        {
            using (AnnuaireContext context = new AnnuaireContext())
            {
                context.Service.Add(new Service { Nom = "Comptabilité" });
                context.Service.Add(new Service { Nom = "Production" });
                context.Service.Add(new Service { Nom = "Accueil" });
                context.Service.Add(new Service { Nom = "Informatique" });
                context.Service.Add(new Service { Nom = "Commercial" });
                context.SaveChanges();
            }

        }
    }
}

