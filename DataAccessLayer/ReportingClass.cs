using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    class ReportingClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public DataTable GetMemberByProject(String ProjectName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,memberName from ProjectTable p,MemberTable m,ProjectMemberTable pmt where pmt.ProjectId=p.ProjectId and pmt.memberId=m.memberId and ProjectName=@ProjectName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBugsByProjectAndMember(String memberName, String ProjectName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select BugId,BugDetails,EntryDate,ClassName,MethodName,BlockName,LineNumber from BugTable,ProjectTable,MemberTable where ProjectTable.ProjectId=BugTable.ProjectId and MemberTable.memberId=BugTable.memberId and memberName=@memberName and ProjectName=@ProjectName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                cmd.Parameters.AddWithValue("@memberName", memberName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable ProjectReportByMember(int memberId)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,ProjectDescription,StartDate,EndDate,memberName,UserName,MemberRole,Responsibilities from ProjectMemberTable,MemberTable,ProjectTable where ProjectMemberTable.memberId=MemberTable.memberId and ProjectTable.ProjectId=ProjectMemberTable.ProjectId and MemberTable.memberId=@memberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable AllProjectReport()
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,ProjectDescription,StartDate,EndDate,memberName,UserName,MemberRole,Responsibilities from ProjectMemberTable,MemberTable,ProjectTable where ProjectMemberTable.memberId=MemberTable.memberId and ProjectTable.ProjectId=ProjectMemberTable.ProjectId ", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable AllProjectsByDates(String projectStartDate, String projectEndDate)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from ProjectTable where projectStartDate>=@projectStartDate and  projectEndDate<=@projectEndDate", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@projectStartDate", projectStartDate);
                cmd.Parameters.AddWithValue("@projectEndDate", projectEndDate);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBugByMember(int memberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.memberName,ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber from BugEntryTable b,MemberTable m,ProjectTable p where m.memberId=b.memberId and b.ProjectId=p.ProjectId  and m.memberId=@memberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBugByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.memberName,ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber from BugEntryTable b,MemberTable m,ProjectTable p where m.memberId=b.memberId and b.ProjectId=p.ProjectId  and p.ProjectId=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetSolutionsByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProjectName,b.BugId,b.BugDetails,b.ClassName,b.MethodName,b.BlockName,b.LineNumber,s.SolutionDate,s.SolutionDetails from SolutionTable s,BugEntryTable b,ProjectTable p where b.BugId=s.BugId and p.ProjectId=b.ProjectId and p.ProjectId=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetSolutionsByMember(int memberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProjectName,b.BugId,b.BugDetails,b.ClassName,b.MethodName,b.BlockName,b.LineNumber,s.dateOfSolutionIdentified,s.SolutionDetails from BugSolutionTable s,BugEntryTable b,ProjectTable p,MemberTable m where b.BugId=s.BugId and p.ProjectId=b.ProjectId and  b.memberId=m.memberId and m.memberId=@memberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetProjectByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,MemberRole,ProjectDescription,Responsibilities from ProjectMemberTable pmt,MemberTable m,ProjectTable p where pmt.memberId=m.memberId and p.ProjectId=pmt.ProjectId and m.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int GetTotalProjectByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select count(*) from ProjectMemberTable pmt,MemberTable m where m.memberId=pmt.memberId and m.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalProject = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalProject;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetBugByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectTable.ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber,EntryDate from BugTable,MemberTable,ProjectTable  where BugTable.memberId=MemberTable.memberId and ProjectTable.ProjectId=BugTable.ProjectId and MemberTable.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int TotalBugsByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select count(*) from BugTable b,MemberTable m where b.memberId=m.memberId and m.UserName=@UserName ", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalBugs = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalBugs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetSolutionsByUserName(string UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select SolutionId,SolutionTable.BugId,BugTable.BugDetails,SolutionDetails,SolutionDate from SolutionTable,BugTable,MemberTable where BugTable.BugId=SolutionTable.BugId and BugTable.memberId=MemberTable.memberId and MemberTable.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int GetTotalSolutions(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from SolutionTable,MemberTable,BugTable where SolutionTable.BugId=BugTable.BugId and BugTable.memberId=MemberTable.memberId and UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalSolutions = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalSolutions;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
