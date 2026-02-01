using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Model
{
    [Table("CompetencyDetails")]
    public class CompetencyDetails
    {
        [Key]
        public int CompID { get; set; }

        [Required]
        public string CompName { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
