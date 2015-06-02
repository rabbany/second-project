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
    class ZoneGateway
    {


        public List<Zone> GetZoneByVisitorId(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Visitor WHERE ID='" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Zone> zoneList = new List<Zone>();
            while (sqlDataReader.Read())
            {
                Zone zone = new Zone();
                zone.Id = int.Parse(sqlDataReader["ZoneId"].ToString());
                zone.Name = sqlDataReader["Name"].ToString();
                zoneList.Add(zone);
            }
            return zoneList;
        }
        public List<Zone> GetZoneList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Zone";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Zone> zoneList = new List<Zone>();
            while (sqlDataReader.Read())
            {
                Zone zone = new Zone();
                zone.Id = int.Parse(sqlDataReader["ID"].ToString());
                zone.Name = sqlDataReader["ZoneName"].ToString();
                zoneList.Add(zone);
            }
            return zoneList;
        }

        public bool Save(Zone zone)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_Zone (ZoneName) VALUES('" + zone.Name + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
