using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Model
{
    public class RoleDetail
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
