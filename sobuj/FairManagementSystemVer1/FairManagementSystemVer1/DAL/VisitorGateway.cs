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
    class VisitorGateway
    {
        public int Save(VisitorEntry visitor)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_Visitor (Name,Email,CNumber) OUTPUT INSERTED.ID VALUES('" + visitor.Name + "','" + visitor.Email + "'," + visitor.CNumber + ")";
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

       /* public void Save(VisitorEntry visitorEntry)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO VisitorEntryZone (ID,Name,Email,CNumber,ZoneId) VALUES('" + visitorEntry.ID + "','" + visitorEntry.Name + "','" + visitorEntry.Email + "','" + visitorEntry.CNumber + "','" + visitorEntry.ZoneId+ "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        */

        public VisitorEntry GetVisitorById(int visitorId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Visitor WHERE ID='" + visitorId + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            VisitorEntry visitorEntry = new VisitorEntry();
            while (sqlDataReader.Read())
            {

                visitorEntry.ID = int.Parse(sqlDataReader["ID"].ToString());
                visitorEntry.Name = sqlDataReader["Name"].ToString();
            }
            return visitorEntry;
        }

        public int Update(VisitorEntry visitor)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE tbl_Visitor SET Name='" + visitor.Name + "',Email='" + visitor.Email + "' ,CNumber'" + visitor.CNumber + "',WHERE Id='" + visitor.ID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 1)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }

    /*    public void DeleteExisting(VisitorEntry visitorEntry)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "DELETE FROM tbl_Visitio WHERE ID='" + visitorEntry.ID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }*/

      
    }
}
