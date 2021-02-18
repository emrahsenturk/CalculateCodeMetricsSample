using System;
using System.Runtime.Serialization;

namespace CalculateCodeMetricsSample.Exceptions
{
    [Serializable]
    public class StudentAlreadyRegisteredException : Exception
    {
        public StudentAlreadyRegisteredException(Guid id) : base($"Student Id : {id} - Student already registered.")
        {
        }
    }
}
