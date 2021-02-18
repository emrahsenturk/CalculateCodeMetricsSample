using CalculateCodeMetricsSample.Entities.Concrete;
using CalculateCodeMetricsSample.Models.Abstract;

namespace CalculateCodeMetricsSample.Models.Concrete
{
    public class LessonExamModel : LessonExam, IBaseModel
    {
        public virtual LessonModel Lesson { get; set; }
        public virtual ExamModel Exam { get; set; }
    }
}
