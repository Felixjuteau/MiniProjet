using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;
namespace biblioBDDPersonels1
{
    public class CBDDPersonels1
    {
        private BddpersonnelDataContext dc=null;

        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }
        public List<Service> GetAllServices()//permet de recuperer tout les services de la bdd 
        {
            try
            {
                return dc.Services.OrderBy(y => y.Intitule).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Service> GetServicestrier()
        {
            //List<Service> services = dc.Services.ToList();
            //services.Sort();
            //return services;
            return dc.Services.OrderBy(y=>y.Intitule).ToList();

        }
        //return bdd.Personnels.Where(xx => x.Service.Id == service Id.OrderBy( y=> y.nom).then(y=>u.Prenom).ToList();

    }
}
