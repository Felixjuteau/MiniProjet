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
    }
}
