using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ProjectClass
    {

        /// <summary>
        /// Here I will declare a method to manage project information i.e. to control addition or modification of the project
        /// For this at first I will establish databaseConnectionection with database with the help of  SqlConnection Class and databaseConnectionClass control the databaseConnectionection string hold by Application Configuration file
        /// Then I will declare a parameterized method holding parameters of different datatypes as per the information which will be hold by database
        /// </summary>
        SqlConnection databaseConnection = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageProjects(int projectId,
            String projectName,
            DateTime projectStartDate,
            DateTime projectEndDate,
            String projectDescription,
            int mode)
        {
            try
            {
                SqlCommand commandToManageProjectTable = new SqlCommand("SP_ManageProjects", databaseConnection);
                commandToManageProjectTable.CommandType = CommandType.StoredProcedure;
                commandToManageProjectTable.Parameters.AddWithValue("@projectId", projectId);
                commandToManageProjectTable.Parameters.AddWithValue("@projectName", projectName);
                commandToManageProjectTable.Parameters.AddWithValue("@projectStartDate", projectStartDate);
                commandToManageProjectTable.Parameters.AddWithValue("@projectEndDate", projectEndDate);
                commandToManageProjectTable.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                commandToManageProjectTable.Parameters.AddWithValue("@mode", mode);
                databaseConnection.Open();
                int resultOfManageProject = commandToManageProjectTable.ExecuteNonQuery();
                databaseConnection.Close();
                return resultOfManageProject;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        /// <summary>
        /// Here I will declare a DataTable which will get information of all the project from ProjectTable
        /// And then I will SQLCommand  of CommandType Text to run query for selecting all the project information from ProjectTable
        /// And Since I am using databaseConnectionection Model as DataAccessModel I will first open the database databaseConnectionnection and initiate SQLDataReader to fetch data using SQLCommand
        /// Now I will Load the fetched data to the DataTable and then Close the databaseConnectionection
        /// and Finally I will return the internally declared data table so as to return the information fetched from the database
        /// </summary>
        /// <returns></returns>
        public DataTable getAllProjects()
        {
            try
            {
                DataTable dataTableToGetAllProjects = new DataTable();
                SqlCommand dataSelectionCommand = new SqlCommand("Select * from ProjectTable", databaseConnection);
                dataSelectionCommand.CommandType = CommandType.Text;
                databaseConnection.Open();
                SqlDataReader dataReaderForGettingAllProjects = dataSelectionCommand.ExecuteReader();
                dataTableToGetAllProjects.Load(dataReaderForGettingAllProjects);
                databaseConnection.Close();
                return dataTableToGetAllProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
        /// <summary>
        /// This method is declared to count the the number Of Projects
        /// </summary>
        /// <returns></returns>
        public int countNumberOfProjects()
        {
            try
            {
                DataTable dataTableToCountNumberOfProjects = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from ProjectTable", databaseConnection);
                databaseConnection.Open();
                SqlDataReader dataReaderToGetNumberOfProjectsInDatabase = cmd.ExecuteReader();
                dataTableToCountNumberOfProjects.Load(dataReaderToGetNumberOfProjectsInDatabase);
                databaseConnection.Close();
                int numberOfProjects = Convert.ToInt32(dataTableToCountNumberOfProjects.Rows[0][0].ToString());
                return numberOfProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { databaseConnection.Close(); }
        }
    }
}
