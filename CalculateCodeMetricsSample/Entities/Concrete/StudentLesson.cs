using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Entities.Concrete
{
    public class StudentLesson : BaseEntity
    {
        public string StudentId { get; set; }
        public string LessonId { get; set; }
    }
}
