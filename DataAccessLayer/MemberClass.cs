using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class MemberClass
    {
        SqlConnection databaseConnection = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageMembers(int memberId,
            String memberName,
            String memberAddress,
            String contactNumber,
            String emailAddress,
            String gender,
            DateTime dateOfBirth,
            DateTime dateOfJoin,
            String memberDesignation,
            byte[] profilePicture,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageMembers", databaseConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@memberName", memberName);
                cmd.Parameters.AddWithValue("@memberAddress", memberAddress);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@dateOfJoin", dateOfJoin);
                cmd.Parameters.AddWithValue("@memberDesignation", memberDesignation);
                cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                databaseConnection.Open();
                int result = cmd.ExecuteNonQuery();
                databaseConnection.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        public DataTable getAllMembers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from MemberTable", databaseConnection);
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
        public String getRole(String UserName, String Password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select Role from MemberTable where UserName=@UserName and Password=@Password", databaseConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                databaseConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                databaseConnection.Close();
                String Role = dt.Rows[0]["Role"].ToString();
                return Role;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        public int totalMember()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from MemberTable", databaseConnection);
                databaseConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                databaseConnection.Close();
                int TotalMember = Convert.ToInt32(dt.Rows[0][0].ToString());
                return TotalMember;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        public int GetmemberIdByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select memberId from MemberTable where UserName=@UserName", databaseConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                databaseConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                databaseConnection.Close();
                int memberId = Convert.ToInt32(dt.Rows[0][0].ToString());
                return memberId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
    }
}
