using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public class UserRoleClass
    {
       SqlConnection databaseConnection = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageUserRole(int userRoleId,
            String userRole,
            String roleDescription,
            int mode)
        {
            try
            {
                int result = 0;
                SqlCommand commandToManageUserRole = new SqlCommand("SP_ManageUserRole", databaseConnection);
                commandToManageUserRole.CommandType = CommandType.StoredProcedure;
                commandToManageUserRole.Parameters.AddWithValue("@userRoleId", userRoleId);
                commandToManageUserRole.Parameters.AddWithValue("@userRole", userRole);
                commandToManageUserRole.Parameters.AddWithValue("@roleDescription", roleDescription);
                commandToManageUserRole.Parameters.AddWithValue("@mode", mode);
                databaseConnection.Open();
                result = commandToManageUserRole.ExecuteNonQuery();
                databaseConnection.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public DataTable getAllUserRoles()
        {
            try
            {
                DataTable dataTableToGetAllTheRoleInformation = new DataTable();
                SqlCommand commandToGetAllTheRoleInformation = new SqlCommand("SELECT * FROM UserRoleTable", databaseConnection);
                commandToGetAllTheRoleInformation.CommandType = CommandType.Text;
                databaseConnection.Open();
                SqlDataReader dataReaderToGetAllTheRoleInformation = commandToGetAllTheRoleInformation.ExecuteReader();
                dataTableToGetAllTheRoleInformation.Load(dataReaderToGetAllTheRoleInformation);
                databaseConnection.Close();
                return dataTableToGetAllTheRoleInformation;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
