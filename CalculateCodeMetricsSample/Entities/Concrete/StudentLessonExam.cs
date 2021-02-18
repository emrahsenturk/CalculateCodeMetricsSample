using System;

namespace CalculateCodeMetricsSample.Entities.Concrete
{
    public class StudentLessonExam : BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid LessonExamId { get; set; }
        public int Result { get; set; }
    }
}
