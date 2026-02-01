using System.Collections.Generic;
using DL_SmartAppraisal.Model;

namespace DL_SmartAppraisal.Abstract
{
    public interface IDL_UserManagement
    {
        List<UserDetail> GetUserDetails();
        List<RoleDetail> GetRoles();
        List<DesignationDetail> GetDesignations();
        UserDetail GetUserById(int id);
        string InsertUser(UserDetail userDetail);
        string UpdateUser(UserDetail userDetail);
        string DeleteUser(int id);

        UserDetail ValidateLogin(string loginId, string password, int roleId, int designationId);

        void ChangePassword(int userId, string newPassword);
        UserDetail ValidateUserOnly(string userName, string password);
        bool ChangePasswordWithValidation(int userId, string oldPassword, string newPassword);
        bool ChangePasswordWithOldPassword(int userId, string oldPassword, string newPassword);
        

    }
}
