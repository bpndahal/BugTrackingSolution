using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
  public  class ProjectMemberClass
    {
        SqlConnection databaseConnection = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageMembersInProject(int id,
            int projectId,
            int memberId,
            String memberRole,
            String memberResponsibilities,
            int mode)
        {
            try
            {
                int rs = 0;
                SqlCommand commandToManageMembersInProject = new SqlCommand("SP_ManageMembersInProject", databaseConnection);
                commandToManageMembersInProject.CommandType = CommandType.StoredProcedure;
                commandToManageMembersInProject.Parameters.AddWithValue("@id", id);
                commandToManageMembersInProject.Parameters.AddWithValue("@projectId", projectId);
                commandToManageMembersInProject.Parameters.AddWithValue("@memberId", memberId);
                commandToManageMembersInProject.Parameters.AddWithValue("@memberRole", memberRole);
                commandToManageMembersInProject.Parameters.AddWithValue("@memberResponsibilities", memberResponsibilities);
                commandToManageMembersInProject.Parameters.AddWithValue("@mode", mode);
                databaseConnection.Open();
                rs = commandToManageMembersInProject.ExecuteNonQuery();
                databaseConnection.Close();
                return rs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        public DataTable getAllMembersInProject()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand commandToGetAllMembersInProject = new SqlCommand("SELECT mp.id,p.projectName,m.memberName,mp.memberRole,mp.memberResponsibilities FROM MemberInProjectTable mp, ProjectTable p, MemberTable m WHERE mp.projectId=p.projectId AND mp.memberId=m.memberId", databaseConnection);
                databaseConnection.Open();
                SqlDataReader dr = commandToGetAllMembersInProject.ExecuteReader();
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
        public DataTable GetProjectBymemberId(int memberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select p.ProjectName,p.ProjectId from ProjectMemberTable pm,ProjectTable p where memberId=@memberId and p.ProjectId=pm.ProjectId", databaseConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
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
        public DataTable getProjectMemberByProjectId(int projectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand commandToGetAllMembersInParticularProjectByProjectId = new SqlCommand("Select * from MemberInProjectTable where projectId=@projectId", databaseConnection);
                commandToGetAllMembersInParticularProjectByProjectId.CommandType = CommandType.Text;
                commandToGetAllMembersInParticularProjectByProjectId.Parameters.AddWithValue("@projectId", projectId);
                databaseConnection.Open();
                SqlDataReader dr = commandToGetAllMembersInParticularProjectByProjectId.ExecuteReader();
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

        public int totalProjectMember()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from ProjectMemberTable", databaseConnection);
                databaseConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                databaseConnection.Close();
                int x = Convert.ToInt32(dt.Rows[0][0].ToString());
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
    }
}
