using System;
using System.Collections.Generic;
using System.Linq;
using DL_SmartAppraisal.Abstract;
using DL_SmartAppraisal.Data;
using DL_SmartAppraisal.Model;
using Microsoft.EntityFrameworkCore;

namespace DL_SmartAppraisal.Repository
{
    public class DL_AssessmentManagement : IDL_AssessmentManagement
    {
        private readonly SmartAppraisalDbContext _context;

        public DL_AssessmentManagement(SmartAppraisalDbContext context)
        {
            _context = context;
        }

        public List<AssessmentInfo> GetAllAssessments() 
        {
            if (_context.AssessmentInfo == null)
                return new List<AssessmentInfo>();

            return _context.AssessmentInfo
    .OrderByDescending(a => a.AssessmentId)
    .Select(a => new AssessmentInfo
    {
        AssessmentId = a.AssessmentId,
        AssessmentDate = a.AssessmentDate,
        // other properties
    })
    .ToList();
        }


        public AssessmentInfo GetAssessmentById(int assessmentId)
        {
            if (_context.AssessmentInfo == null)
                return null;

#pragma warning disable CS8603 // Possible null reference return.
            return _context.AssessmentInfo
                .FirstOrDefault(a => a.AssessmentId == assessmentId);
#pragma warning restore CS8603 // Possible null reference return.
        }


        public bool CreateAssessment(AssessmentInfo assessment)
        {
            if (assessment == null || _context.AssessmentInfo == null)
                return false;

            _context.AssessmentInfo.Add(assessment);
            return _context.SaveChanges() > 0;
        }


        public bool UpdateAssessment(AssessmentInfo assessment)
        {
            if (assessment == null || _context.AssessmentInfo == null)
                return false;

            var existingAssessment = _context.AssessmentInfo
                .FirstOrDefault(a => a.AssessmentId == assessment.AssessmentId);

            if (existingAssessment == null)
                return false;

            existingAssessment.AssessmentName = assessment.AssessmentName;
            existingAssessment.AssessmentDate = assessment.AssessmentDate;
            existingAssessment.Description = assessment.Description;
            existingAssessment.IsActive = assessment.IsActive;

            return _context.SaveChanges() > 0;
        }


        public bool DeleteAssessment(int assessmentId)
        {
            if (_context.AssessmentInfo == null)
                return false;

            var assessment = _context.AssessmentInfo
                .FirstOrDefault(a => a.AssessmentId == assessmentId);

            if (assessment == null)
                return false;

            _context.AssessmentInfo.Remove(assessment);
            return _context.SaveChanges() > 0;
        }

    }
}