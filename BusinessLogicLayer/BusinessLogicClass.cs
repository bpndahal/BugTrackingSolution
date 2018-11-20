using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        ProjectClass projectClass = new ProjectClass();
        MemberClass memberClass = new MemberClass();
        UserRoleClass userRoleClass = new UserRoleClass();
        UserClass userClass = new UserClass();
        ProjectMemberClass projectMemberClass = new ProjectMemberClass();
        BugEntryClass bugEntryClass = new BugEntryClass();
        BugSolutionEntryClass bugSolutionEntryClass = new BugSolutionEntryClass();

        /// <summary>
        /// Here I wiil create a boolean Method with parameter to check if values has been passed in the 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectStartDate"></param>
        /// <param name="projectEndDate"></param>
        /// <param name="projectDescription"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool manageProjects(int projectId,
          String projectName,
          DateTime projectStartDate,
          DateTime projectEndDate,
          String projectDescription,
          int mode)
        {
            try
            {
                bool result = false;
                int rs = projectClass.manageProjects(projectId, projectName, projectStartDate, projectEndDate, projectDescription, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool manageMembers(int memberId,
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
                bool result = false;
                int rs = memberClass.ManageMembers(memberId,
                    memberName,
                    memberAddress,
                    contactNumber,
                    emailAddress,
                    gender,
                    dateOfBirth,
                    dateOfJoin,
                    memberDesignation,
                    profilePicture,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool manageUserRole(int userRoleId,
            String userRole,
            String roleDescription,
            int mode)
        {
            try
            {
                bool result = false;
                int rs = userRoleClass.manageUserRole(userRoleId, userRole, roleDescription, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool manageUsers(int userId,
            int userRoleId,
            int memberId,
            String userName,
            String userPassword,
            int mode)
        {
            try
            {
                bool result = false;
                int rs = userClass.manageUsers(userId, userRoleId, memberId, userName, userPassword, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool manageProjectMembers(int id,
           int projectid,
           int memberid,
           String memberRole,
           String memberResponsibilities,
           int Mode)
        {
            try
            {
                int rs = projectMemberClass.manageMembersInProject(id, projectid, memberid, memberRole, memberResponsibilities, Mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool manageBugs(int bugId,
            DateTime bugIdentifiedDate,
            int memberId,
            int projectId,
            String classLibraryName,
            String className,
            String methodName,
            String blockName,
            String lineNumber,
            String bugDetails,
            byte[] snapShotOfBugMessage,
            String codeContainingBug,
            int mode)
        {
            try
            {
                int rs = bugEntryClass.manageBugs(bugId, bugIdentifiedDate, memberId, projectId, classLibraryName, className, methodName, blockName, lineNumber, bugDetails, snapShotOfBugMessage, codeContainingBug, mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool manageBugSolutions(int bugSolutionId,
            DateTime dateOfSolutionIdentified,
            int projectId,
            int bugId,
            int memberId,
            string solutionDetails,
            string codeAfterFixingBug,
            int mode)
        {
            try
            {
                int rs = bugSolutionEntryClass.manageBugSolutions(bugSolutionId, dateOfSolutionIdentified, projectId, bugId, memberId, solutionDetails, codeAfterFixingBug, mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
