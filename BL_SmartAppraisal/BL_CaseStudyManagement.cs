using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Model;
using DL_SmartAppraisal.Repoistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_SmartAppraisal
{
    public class BL_CaseStudyManagement
    {
        private readonly IDL_CaseStudyManagement _dlCaseStudy;

        public BL_CaseStudyManagement(IDL_CaseStudyManagement dlCaseStudy)
        {
            _dlCaseStudy = dlCaseStudy;
        }

        public void CreateCaseStudy(CaseStudySolutionDetails model)
        {
            _dlCaseStudy.CreateCaseStudy(model);
        }

        public CaseStudySolutionDetails GetByAssessmentId(int assessmentId)
        {
            return _dlCaseStudy.GetCaseStudyByAssessmentId(assessmentId);
        }
    }

}
