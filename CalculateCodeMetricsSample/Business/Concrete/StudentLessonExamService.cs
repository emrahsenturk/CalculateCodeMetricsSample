using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class StudentLessonExamService : IStudentLessonExamService
    {
        protected List<StudentLessonExamModel> studentLessonExams = new List<StudentLessonExamModel>
        {
            new StudentLessonExamModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-123400000000"),
                StudentId = Guid.Parse("AAAAAAAA-0000-0000-0000-000000000000"),
                LessonExamId = Guid.Parse("00000000-0000-1234-0000-000000000000"),
                Result = 80,
                LessonExam = new LessonExamModel
                {
                    Id = Guid.Parse("00000000-0000-1234-0000-000000000000"),
                    LessonId = Guid.Parse("11111111-0000-0000-0000-000000000000"),
                    ExamId = Guid.Parse("00000000-1111-0000-0000-000000000000"),
                    Percent = 40
                }
            },
            new StudentLessonExamModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-432100000000"),
                StudentId = Guid.Parse("AAAAAAAA-0000-0000-0000-000000000000"),
                LessonExamId = Guid.Parse("00000000-0000-4321-0000-000000000000"),
                Result = 60,
                LessonExam = new LessonExamModel
                {
                    Id = Guid.Parse("00000000-0000-4321-0000-000000000000"),
                    LessonId = Guid.Parse("11111111-0000-0000-0000-000000000000"),
                    ExamId = Guid.Parse("00000000-2222-0000-0000-000000000000"),
                    Percent = 60
                }
            }
        };

        public List<StudentLessonExamModel> GetExamResults(Guid studentId, Guid lessonId)
        {
            return studentLessonExams.FindAll(p => p.StudentId == studentId && p.LessonExamId == lessonId);
        }
    }
}
