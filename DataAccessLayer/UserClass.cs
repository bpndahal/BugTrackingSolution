using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class UserClass
    {
        SqlConnection databaseConnection = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageUsers(int userId,
            int userRoleId,
            int memberId,
            String userName,
            String userPassword,
            int mode)
        {
            try
            {
                int result = 0;
                SqlCommand commandToManageUsers = new SqlCommand("SP_ManageUsers", databaseConnection);
                commandToManageUsers.CommandType = CommandType.StoredProcedure;
                commandToManageUsers.Parameters.AddWithValue("@userId", userId);
                commandToManageUsers.Parameters.AddWithValue("@userRoleId", userRoleId);
                commandToManageUsers.Parameters.AddWithValue("@memberId", memberId);
                commandToManageUsers.Parameters.AddWithValue("@userName", userName);
                commandToManageUsers.Parameters.AddWithValue("@userPassword", userPassword);
                commandToManageUsers.Parameters.AddWithValue("@mode", mode);
                databaseConnection.Open();
                result = commandToManageUsers.ExecuteNonQuery();
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
        public DataTable getAllUsers()
        {
            try
            {
                DataTable dataTableTogetAllUsers = new DataTable();
                SqlCommand dataSelectionCommand = new SqlCommand("select u.userId as Id,m.memberName as Name,u.userName as Username,u.userPassword as Password, r.userRole as Role from UserTable u, MemberTable m, UserRoleTable r where u.userRoleId=r.userRoleId and u.memberId=m.memberId", databaseConnection);
                dataSelectionCommand.CommandType = CommandType.Text;
                databaseConnection.Open();
                SqlDataReader dataReaderForGettingAllUsers = dataSelectionCommand.ExecuteReader();
                dataTableTogetAllUsers.Load(dataReaderForGettingAllUsers);
                databaseConnection.Close();
                return dataTableTogetAllUsers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        public DataTable userType(String userName, String userPassword)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select userRole from UserRoleTable where userRoleId=(select userRoleId from UserTable where userName=@userName and userPassword=@userPassword)", databaseConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", userPassword);
                databaseConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                databaseConnection.Close();

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
    }
}
