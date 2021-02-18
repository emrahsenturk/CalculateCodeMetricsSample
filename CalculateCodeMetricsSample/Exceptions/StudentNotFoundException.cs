using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Exceptions
{
    [Serializable]
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(Guid id) : base($"Student Id : {id} - Student not found.")
        {
        }
    }
}
