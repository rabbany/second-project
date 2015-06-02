using FairManagementSystemVer1.DAL;
using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemVer1.BLL
{
    class VisitorZoneManger
    {

        VisitorZoneGateway aVisitorZoneGateway = new VisitorZoneGateway();
        public int Save(ZoneType zoneType)
        {
            return aVisitorZoneGateway.Save(zoneType);
        }

        public List<VisitorEntry> GetInfoVisitorList(int zoneid)
        {
            VisitorZoneGateway visitorZoneGateway = new VisitorZoneGateway();
            return visitorZoneGateway.GetInfoByZoneId(zoneid);
        }

        public List<VisitorEntry> GetCountVisitorList()
        {
            VisitorZoneGateway visitorZoneGateway = new VisitorZoneGateway();
            return visitorZoneGateway.GetCountByVisitor();
        }

        

        
    }
}
