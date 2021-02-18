using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Business.Abstract
{
    public interface IStudentLessonService
    {
        string GetResult(Guid studentId, Guid lessonId);
    }
}
