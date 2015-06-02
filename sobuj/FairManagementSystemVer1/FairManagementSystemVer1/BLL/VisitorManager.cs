using FairManagementSystemVer1.DAL;
using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemVer1.BLL
{
    class VisitorManager
    {
        VisitorGateway visitorGateway = new VisitorGateway();

        public VisitorEntry GetVisitorById(int visitorId)
        {
            return visitorGateway.GetVisitorById(visitorId);
        }

        public int Update(VisitorEntry visitor)
        {
            return visitorGateway.Update(visitor);
        }


        public int Save(VisitorEntry visitor)
        {
            return visitorGateway.Save(visitor);
        }

       

       
    }
}
