using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Business.Abstract
{
    public interface IStudentLessonExamService
    {
        List<StudentLessonExamModel> GetExamResults(Guid studentId, Guid lessonId);
    }
}
