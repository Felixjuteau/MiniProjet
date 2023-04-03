using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using BddpersonnelContext;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace biblioBDDPersonels1
{
    public class CBDDPersonels1
    {
        private BddpersonnelDataContext dc = null;
        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }
        public List<Service> GetAllServices()//permet de recuperer tout les services de la bdd 
        {
            try{
                return dc.Services.ToList();
            }
            catch (Exception ex){
                throw ex;
            }
        }
        public List<Fonction> GetAllFonction()//permet de recuperer tout les services de la bdd 
        {
            try{
                return dc.Fonctions.ToList();
            }
            catch (Exception ex){
                throw ex;
            }
        }
        public List<Personnel> GetAllPersonnels()
        {
            try { 
                return dc.Personnels.ToList(); 
            } 
            catch (Exception ex) { 
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
    public Service GetServicebyintitule(string intitule) {
        return dc.Services.Where(x=>x.Intitule== intitule).FirstOrDefault();
        }
        public Fonction GetFonctionbyintitule(string intitule)
        {
            return dc.Fonctions.Where(x=>x.Intitule==intitule).FirstOrDefault();
        }


        public Personnel GetPersonnel(string _Prenom,string _Nom,int _IdService,int _IdFonction,string _Telephone,byte[] _Photo) {//permet de recuperer 
            Personnel personnel = new Personnel();
            personnel.Prenom = _Prenom;
            personnel.Nom = _Nom;
            personnel.IdService = _IdService;
            personnel.IdFonction = _IdFonction;
            personnel.Telephone = _Telephone;
            personnel.Photo = _Photo;
            return personnel;
        }
     
        public void ModifPersonel(Personnel personnel)
        {
            try
            {
                int id = personnel.Id;
                Personnel personnel2 = dc.Personnels.Single(x => x.Id == id);
                personnel2.Nom= personnel.Nom;
                personnel2.Prenom = personnel.Prenom;
                personnel2.Telephone= personnel.Telephone;
                personnel2.Photo= personnel.Photo;
                personnel2.IdService = 5;  // personnel.IdService;
                personnel2.IdFonction= personnel.IdFonction;
                dc.SubmitChanges();
            }
            catch (Exception ex) { throw ex; };
        }
        //return bdd.Personnels.Where(xx => x.Service.Id == service Id.OrderBy( y=> y.nom).then(y=>u.Prenom).ToList();
        
    }
}
    

