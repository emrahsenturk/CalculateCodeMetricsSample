using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Exceptions
{
    [Serializable]
    public class LessonNotFoundException : Exception
    {
        public LessonNotFoundException(Guid id) : base($"Lesson Id : {id} - Lesson not found.")
        {
        }
    }
}
