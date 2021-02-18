using CalculateCodeMetricsSample.Entities.Concrete;
using CalculateCodeMetricsSample.Models.Abstract;

namespace CalculateCodeMetricsSample.Models.Concrete
{
    public class StudentLessonModel : StudentLesson, IBaseModel
    {
        public virtual StudentModel Student { get; set; }
        public virtual LessonModel Lesson { get; set; }
    }
}
