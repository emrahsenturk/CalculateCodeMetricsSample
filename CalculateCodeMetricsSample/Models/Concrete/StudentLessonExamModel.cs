using CalculateCodeMetricsSample.Entities.Concrete;
using CalculateCodeMetricsSample.Models.Abstract;

namespace CalculateCodeMetricsSample.Models.Concrete
{
    public class StudentLessonExamModel : StudentLessonExam, IBaseModel
    {
        public virtual StudentModel Student { get; set; }
        public virtual LessonExamModel LessonExam { get; set; }
    }
}
