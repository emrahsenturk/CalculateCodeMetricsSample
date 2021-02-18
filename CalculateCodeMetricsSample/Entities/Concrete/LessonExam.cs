using System;

namespace CalculateCodeMetricsSample.Entities.Concrete
{
    public class LessonExam : BaseEntity
    {
        public Guid LessonId { get; set; }
        public Guid ExamId { get; set; }
        public int Percent { get; set; }
    }
}
