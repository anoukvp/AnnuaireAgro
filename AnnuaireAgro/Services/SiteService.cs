using AnnuaireAgro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace AnnuaireAgro.Services
{
    class SiteService
    {

        #region Singleton

        private static SiteService instance;
        public static SiteService Instance //propriété statique = au niveau de la classe
        {
            get
            {
                if (instance == null)
                {
                    instance = new SiteService(); //auto instanciation la 1ère fois !
                }
                return instance;
            }
        }

        private SiteService() //constructeur privé pour empecher une instanciation externe
        {

        }

        #endregion

        public List<Models.Site> ChargerSite()
        {
            List<Models.Site> lst = new List<Models.Site>();

            using (AnnuaireContext context = new AnnuaireContext())
            {
                var lstSites = context.Site.ToList();
                lst.AddRange(lstSites);

            }

            return lst;
        }

        public Models.Site Enregistrer(Models.Site site)
        {

            using (AnnuaireContext context = new AnnuaireContext())

                if (site.Id == 0)
                {
                    //création
                    if (site.GetType() == typeof(Models.Site))

                    {
                        context.Site.Add(site as Models.Site);
                    }

                    else

                    {

                    }


                }
                else
                {
                    //modification
                    if (site.GetType() == typeof(Models.Site))

                    {
                        context.Site.Update(site as Models.Site);
                    }
                    else

                    {

                    }

                    context.SaveChanges();

                }



            return site;



        }

        public bool Supprimer(Models.Site service)
        {

            using (AnnuaireContext context = new AnnuaireContext())
            {

                if (service.Id > 0)
                {
                    //Suppression
                    if (service.GetType() == typeof(Models.Site))

                    {
                        context.Site.Remove(service as Models.Site);
                    }

                    else

                    {

                    }

                }

                context.SaveChanges();

                return true;

            }


        }
    }
}
