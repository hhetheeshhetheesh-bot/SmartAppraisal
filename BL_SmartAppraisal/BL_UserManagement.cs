using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Model;
using System.Collections.Generic;

namespace BL_SmartAppraisal
{
    public class BL_UserManagement
    {
        private readonly IDL_UserManagement _repo;

        // Constructor injection
        public BL_UserManagement(IDL_UserManagement repo)
        {
            _repo = repo;
        }

        public List<UserDetail> GetUserDetails()
        {
            return _repo.GetUserDetails();
        }

        public UserDetail GetUserById(int id)
        {
            return _repo.GetUserById(id);
        }

        public string InsertUser(UserDetail userDetail)
        {
            return _repo.InsertUser(userDetail);
        }

        public string UpdateUser(UserDetail userDetail)
        {
            return _repo.UpdateUser(userDetail);
        }

        public string DeleteUser(int id)
        {
            return _repo.DeleteUser(id);
        }
        public List<RoleDetail> GetRoles()
        {
            return _repo.GetRoles();
        }

        public List<DesignationDetail> GetDesignations()
        {
            return _repo.GetDesignations();
        }

        public UserDetail ValidateLogin(string userName, string password, int roleId, int designationId)
        {
            return _repo.ValidateLogin(userName, password, roleId, designationId);
        }

        
        public UserDetail ValidateUserOnly(string userName, string password)
        {
            return _repo.ValidateUserOnly(userName, password);
        }
        public bool ChangePasswordWithOldPassword(int userId, string oldPassword, string newPassword)
        {
            var user = _repo.GetUserById(userId);
            if (user == null)
                return false;

            user.Password = newPassword;
            user.LastPasswordChangeDate = DateTime.Now; 

            _repo.UpdateUser(user);
            return true;
        }

        
    }
}