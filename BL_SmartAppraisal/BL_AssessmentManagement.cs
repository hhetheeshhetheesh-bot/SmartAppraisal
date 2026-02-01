using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Model;

namespace BL_SmartAppraisal
{
    public class BL_AssessmentManagement
    {
        private readonly IDL_AssessmentManagement _dlAssessmentManagement;

        public BL_AssessmentManagement(IDL_AssessmentManagement dlAssessmentManagement)
        {
            _dlAssessmentManagement = dlAssessmentManagement;
        }

        public List<AssessmentInfo> GetAllAssessments()
        {
            var assessments = _dlAssessmentManagement.GetAllAssessments();

            if (assessments == null || !assessments.Any())
                return new List<AssessmentInfo>();

            return assessments;
        }


        public AssessmentInfo GetAssessmentById(int assessmentId)
        {
            if (assessmentId <= 0)
                return null;

            return _dlAssessmentManagement.GetAssessmentById(assessmentId);
        }


        public bool CreateAssessment(AssessmentInfo assessment)
        {
            if (assessment == null)
                return false;

            if (string.IsNullOrWhiteSpace(assessment.AssessmentName))
                return false;

            if (assessment.AssessmentDate == default)
                return false;

            return _dlAssessmentManagement.CreateAssessment(assessment);
        }


        public bool UpdateAssessment(AssessmentInfo assessment)
        {
            if (assessment == null || assessment.AssessmentId <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(assessment.AssessmentName))
                return false;

            if (assessment.AssessmentDate == default)
                return false;

            return _dlAssessmentManagement.UpdateAssessment(assessment);
        }


        public bool DeleteAssessment(int assessmentId)
        {
            if (assessmentId <= 0)
                return false;

            return _dlAssessmentManagement.DeleteAssessment(assessmentId);
        }


        public List<AssessmentInfo> GetActiveAssessments()
        {
            var assessments = _dlAssessmentManagement.GetAllAssessments();

            if (assessments == null)
                return new List<AssessmentInfo>();

            return assessments.Where(a => a.IsActive).ToList();
        }


        public bool IsAssessmentNameExists(string assessmentName, int? excludeAssessmentId = null)
        {
            if (string.IsNullOrWhiteSpace(assessmentName))
                return false;

            var assessments = _dlAssessmentManagement.GetAllAssessments();

            if (assessments == null)
                return false;

            return assessments.Any(a =>
                a.AssessmentName.Equals(assessmentName, StringComparison.OrdinalIgnoreCase)
                && (!excludeAssessmentId.HasValue || a.AssessmentId != excludeAssessmentId.Value));
        }

    }
}