using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Model
{
    public class DesignationDetail
    {
        [Key]
        public int DesignationId { get; set; }
        public string DesignationName { get; set; } = string.Empty;
    }
}
