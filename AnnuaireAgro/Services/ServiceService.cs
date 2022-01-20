using AnnuaireAgro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Services
{
    class ServiceService
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




    }
}

