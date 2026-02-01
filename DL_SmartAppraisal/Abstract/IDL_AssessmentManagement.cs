using DL_SmartAppraisal.Model;
using System.Collections.Generic;

namespace DL_SmartAppraisal.Abstract
{
    public interface IDL_AssessmentManagement
    {
        List<AssessmentInfo> GetAllAssessments();
        AssessmentInfo GetAssessmentById(int assessmentId);
        bool CreateAssessment(AssessmentInfo assessment);
        bool UpdateAssessment(AssessmentInfo assessment);
        bool DeleteAssessment(int assessmentId);
        
    }
}