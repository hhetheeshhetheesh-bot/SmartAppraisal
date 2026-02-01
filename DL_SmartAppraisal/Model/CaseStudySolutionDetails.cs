using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Model
{
    public class CaseStudySolutionDetails
    {
        [Key]
        public int CSID { get; set; }

        [Required]
        public int AssessmentId { get; set; }

        [Required]
        public string CaseStudy { get; set; }

        public string Soln1 { get; set; }
        public int? Comp1 { get; set; }

        public string Soln2 { get; set; }
        public int? Comp2 { get; set; }

        public string Soln3 { get; set; }
        public int? Comp3 { get; set; }

        public string Soln4 { get; set; }
        public int? Comp4 { get; set; }

        public string CreatedBy { get; set; }

        public bool IsReviewed { get; set; } = false;

        public string? Comments { get; set; }

        // Navigation
        [ForeignKey(nameof(AssessmentId))]
        public AssessmentInfo Assessment { get; set; }
    }
}
