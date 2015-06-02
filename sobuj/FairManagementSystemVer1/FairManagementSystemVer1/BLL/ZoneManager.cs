using FairManagementSystemVer1.DAL;
using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementSystemVer1.BLL
{
    class ZoneManager
    {

        public List<Zone> GetZoneByVisitorId(int id)
        {
            ZoneGateway zoneGateway = new ZoneGateway();
            return zoneGateway.GetZoneByVisitorId(id);
        }
       
        public List<Zone> GetZoneList()
        {
            ZoneGateway zoneGateway = new ZoneGateway();
            return zoneGateway.GetZoneList();
        }

        public bool Save(Zone zone)
        {
            if (zone.Name == "")
            {
                MessageBox.Show("Name cannot be empty");
                return false;
            }
            else
            {
                ZoneGateway zoneGateway = new ZoneGateway();
                return zoneGateway.Save(zone);
            }
        }
    }
}
