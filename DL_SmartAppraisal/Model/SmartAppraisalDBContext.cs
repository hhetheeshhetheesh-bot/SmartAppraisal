using DL_SmartAppraisal.Model;
using Microsoft.EntityFrameworkCore;

namespace DL_SmartAppraisal.Data
{
    public class SmartAppraisalDbContext : DbContext
    {
        public SmartAppraisalDbContext(DbContextOptions<SmartAppraisalDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<RoleDetail> RoleDetails { get; set; }
        public DbSet<DesignationDetail> DesignationDetails { get; set; }
        public DbSet<CompetencyDetails> CompetencyDetails { get; set; }
        public DbSet<AssessmentInfo> AssessmentInfo { get; set; }
        public DbSet<CaseStudySolutionDetails> CaseStudySolutionDetails { get; set; }

    }
}
