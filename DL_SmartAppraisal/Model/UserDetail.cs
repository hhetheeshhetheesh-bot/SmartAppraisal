using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL_SmartAppraisal.Model
{
    public class UserDetail
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public int DesignationId { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }


    }
}
