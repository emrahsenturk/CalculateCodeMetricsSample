using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class ExamService : IExamService
    {
        protected List<ExamModel> exams = new List<ExamModel>
        {
            new ExamModel
            {
                Id = Guid.Parse("00000000-1111-0000-0000-000000000000"),
                Name = "Midterm Exam"
            },
            new ExamModel
            {
                Id = Guid.Parse("00000000-2222-0000-0000-000000000000"),
                Name = "Final Exam"
            }
        };
    }
}
