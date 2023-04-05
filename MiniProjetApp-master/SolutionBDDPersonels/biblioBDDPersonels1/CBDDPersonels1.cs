using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;
using Devart.Common;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace biblioBDDPersonels1

{
    public class CBDDPersonels1
    {
        private BddpersonnelDataContext dc=null;

        //constructeur de base pour accéder à la bdd
        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }

        //constructeur pour accéder à la base en gestionnaire(mais pas uniquement)
        public CBDDPersonels1( string UserId, string Password, string Host, string Database)
        {
            
            string connectionString = "User Id="+UserId+";Password="+Password+";Host="+Host+";Database="+Database+";Persist Security Info=True";
            dc = new BddpersonnelDataContext(connectionString);
           
        }

        public  User GetUser()
        {
            try
            {
                
                return dc.Users.FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //tableau de services à revoir
        public List<Service> GetAllServices()
        {
            try
            {
                return dc.Services.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //tableau des fonctions

        public List<Fonction> GetAllFonctions()
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


        //tableau du personnels
        public List<Personnel> GetAllPersonnels()
        {
            try
            {
                return dc.Personnels.ToList();
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
    public Service GetServicebyintitule(string intitule)
    {
        return dc.Services.Where(x => x.Intitule == intitule).FirstOrDefault();
    }
    public Fonction GetFonctionbyintitule(string intitule)
    {
        return dc.Fonctions.Where(x => x.Intitule == intitule).FirstOrDefault();
    }


    public Personnel GetPersonnel(string _Prenom, string _Nom, int _IdService, int _IdFonction, string _Telephone, byte[] _Photo)
    {//permet de recuperer 
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
        dc.Connection.Open();
        using (System.Data.Common.DbTransaction transaction
        = dc.Connection.BeginTransaction())
        {

            try
            {
                int id = personnel.Id;
                Personnel personnel2 = dc.Personnels.Single(x => x.Id == id);
                dc.SubmitChanges();
                dc.Personnels.InsertOnSubmit(personnel);
                dc.Personnels.DeleteOnSubmit(personnel2);
                dc.SubmitChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            };
        }
    }

    public void SuppPersonnel(int Id)
    {
        try
        {

            Personnel personnel2 = dc.Personnels.Single(x => x.Id == Id);
            dc.Personnels.DeleteOnSubmit(personnel2);
            dc.SubmitChanges();
        }
        catch (Exception ex) { throw ex; };
    }
    public void AjouterPersonnel(Personnel personnel)
    {
        try
        {
            dc.Personnels.InsertOnSubmit(personnel);
            dc.SubmitChanges();
        }
        catch (Exception ex) { throw ex; };
    }
    //return bdd.Personnels.Where(xx => x.Service.Id == service Id.OrderBy(y=> y.nom).then(y=>u.Prenom).ToList();

}
}



