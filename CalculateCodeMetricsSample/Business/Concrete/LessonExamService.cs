using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class LessonExamService : ILessonExamService
    {
        protected List<LessonExamModel> lessonExams = new List<LessonExamModel>
        {
            new LessonExamModel
            {
                Id = Guid.Parse("00000000-0000-1234-0000-000000000000"),
                LessonId = Guid.Parse("11111111-0000-0000-0000-000000000000"),
                ExamId = Guid.Parse("00000000-1111-0000-0000-000000000000"),
                Percent = 40
            },
            new LessonExamModel
            {
                Id = Guid.Parse("00000000-0000-4321-0000-000000000000"),
                LessonId = Guid.Parse("11111111-0000-0000-0000-000000000000"),
                ExamId = Guid.Parse("00000000-2222-0000-0000-000000000000"),
                Percent = 60
            }
        };
    }
}
