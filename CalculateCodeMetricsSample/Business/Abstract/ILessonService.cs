using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Business.Abstract
{
    public interface ILessonService
    {
        LessonModel GetById(Guid id);
    }
}
