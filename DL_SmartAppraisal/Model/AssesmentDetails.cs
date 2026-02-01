using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Model
{

    public class AssessmentInfo
    {
        
        [Key]
        public int AssessmentId { get; set; }
        [Required]
        public string? AssessmentName { get; set; } = string.Empty;
        [Required]
        public DateTime AssessmentDate { get; set; }

        public string Description { get; set; } 

        public bool IsActive { get; set; } = true;

        public int CreatedByRoleId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
