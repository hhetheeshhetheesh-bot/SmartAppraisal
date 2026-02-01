using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Data;
using DL_SmartAppraisal.Model;
using System.Collections.Generic;
using System.Linq;

namespace DL_SmartAppraisal.Repository
{
    public class DL_UserManagement : IDL_UserManagement
    {
        private readonly SmartAppraisalDbContext _context;
        

        public object ErrorLog { get; private set; }

        public DL_UserManagement(SmartAppraisalDbContext context)
        {
            _context = context;
        }

        public List<UserDetail> GetUserDetails()
        {
            return _context.UserDetails.ToList();
        }

        public UserDetail GetUserById(int id)
        {
            return _context.UserDetails.FirstOrDefault(x => x.UserID == id);
        }

        public string InsertUser(UserDetail userDetail)
        {
            _context.UserDetails.Add(userDetail);
            _context.SaveChanges();
            return "User inserted successfully";
        }

        public string UpdateUser(UserDetail userDetail)
        {
            _context.UserDetails.Update(userDetail);
            _context.SaveChanges();
            return "User updated successfully";
        }

        public string DeleteUser(int id)
        {
            var user = _context.UserDetails.Find(id);
            if (user == null)
                return "User not found";

            _context.UserDetails.Remove(user);
            _context.SaveChanges();
            return "User deleted successfully";
        }
        public List<RoleDetail> GetRoles()
        {
            return _context.RoleDetails.ToList();
        }

        public List<DesignationDetail> GetDesignations()
        {
            return _context.DesignationDetails.ToList();
        }

        public UserDetail ValidateLogin(string userName, string password, int roleId, int designationId)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.UserDetails.FirstOrDefault(x =>
                x.UserName == userName &&
                x.Password == password &&
                x.RoleId == roleId &&
                x.DesignationId == designationId
            );
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void ChangePassword(int userId, string newPassword)
        {
            var user = _context.UserDetails.Find(userId);
            if (user != null)
            {
                user.Password = newPassword;
                user.LastPasswordChangeDate = DateTime.Now;
                _context.SaveChanges();
            }
        }


        void IDL_UserManagement.ChangePassword(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }
        public UserDetail ValidateUserOnly(string userName, string password)
        {
            return _context.UserDetails
                .FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }

        public bool ChangePasswordWithValidation(int userId, string oldPassword, string newPassword)
        {
            var user = _context.UserDetails.Find(userId);

            if (user == null || user.Password != oldPassword)
                return false;

            user.Password = newPassword;
            user.LastPasswordChangeDate = DateTime.Now;
            _context.SaveChanges();

            return true;
        }
        public bool ChangePasswordWithOldPassword(int userId, string oldPassword, string newPassword)
        {
            var user = _context.UserDetails.Find(userId);

            if (user == null)
                return false;

            if (user.Password != oldPassword)
                return false;

            user.Password = newPassword;
            user.LastPasswordChangeDate = DateTime.Now;

            _context.SaveChanges();
            return true;
        }
        
        

       
    }

}
