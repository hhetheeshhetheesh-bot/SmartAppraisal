using DL_SmartAppraisal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_SmartAppraisal.Abstract
{
    public interface IDL_CaseStudyManagement
    {
        void CreateCaseStudy(CaseStudySolutionDetails caseStudy);

        CaseStudySolutionDetails GetCaseStudyByAssessmentId(int assessmentId);

        List<CaseStudySolutionDetails> GetAllCaseStudies();
    }
}
