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
        private BddpersonnelDataContext dc = null;

        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }
        public List<Fonction> GetAllServices()//permet de recuperer tout les services de la bdd 
        {
            try
            {
                return dc.Fonctions.ToList();
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
            return dc.Services.OrderBy(y => y.Intitule).ToList();

        }
        public int GetPersonnel(int _Id,string _Prenom,string _Nom,int _IdService,int _IdFonction,string _Telephone,byte[] _Photo) {
            Personnel personnel = new Personnel();
            personnel.Id = _Id;
            personnel.Prenom = _Prenom;
            personnel.Nom = _Nom;
            personnel.IdService = _IdService;
            personnel.IdFonction = _IdFonction;
            personnel.Telephone = _Telephone;
            personnel.Photo = _Photo;
            return 0;
        }

        //return bdd.Personnels.Where(xx => x.Service.Id == service Id.OrderBy( y=> y.nom).then(y=>u.Prenom).ToList();

    }
}
