using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Data;
using DL_SmartAppraisal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Repoistory
{
    public class DL_CaseStudyManagement : IDL_CaseStudyManagement
    {
        private readonly SmartAppraisalDbContext _context;

        public DL_CaseStudyManagement(SmartAppraisalDbContext context)
        {
            _context = context;
        }

        public void CreateCaseStudy(CaseStudySolutionDetails caseStudy)
        {
            _context.CaseStudySolutionDetails.Add(caseStudy);
            _context.SaveChanges();
        }

        public CaseStudySolutionDetails GetCaseStudyByAssessmentId(int assessmentId)
        {
            return _context.CaseStudySolutionDetails
                           .FirstOrDefault(x => x.AssessmentId == assessmentId);
        }

        public List<CaseStudySolutionDetails> GetAllCaseStudies()
        {
            return _context.CaseStudySolutionDetails.ToList();
        }
    }
}
