using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemVer1.DAL
{
    class VisitorZoneGateway
    {
        public int Save(ZoneType zoneType)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_VisitingZone (ZID,VID) OUTPUT INSERTED.ID VALUES('" + zoneType.ZoneId + "'," + zoneType.VisitorId + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (row > 0)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }
        public List<VisitorEntry> GetInfoByZoneId(int zid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT v.ID,Name,Email,CNumber FROM tbl_VisitingZone as vz, tbl_Visitor as v WHERE vz.VID=v.ID and vz.ZID='" + zid + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<VisitorEntry> visitorList = new List<VisitorEntry>();
            while (sqlDataReader.Read())
            {
                VisitorEntry visitor = new VisitorEntry();
                visitor.Name = sqlDataReader["Name"].ToString();
                visitor.Email = sqlDataReader["Email"].ToString();
                visitor.CNumber = sqlDataReader["CNumber"].ToString();
                visitorList.Add(visitor);
            }
            return visitorList;
        }

        public List<VisitorEntry> GetCountByVisitor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT z.ZoneName, count(*) as count_visitor from tbl_Zone as z,tbl_VisitingZone as vz where z.ID=vz.ZID group by z.ZoneName";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<VisitorEntry> visitorList = new List<VisitorEntry>();
            while (sqlDataReader.Read())
            {
                VisitorEntry visitor = new VisitorEntry();
                visitor.Name = sqlDataReader["ZoneName"].ToString();
                visitor.Email = sqlDataReader["count_visitor"].ToString();
                
                visitorList.Add(visitor);
            }
            return visitorList;
            
        }
    }
}
