using CalculateCodeMetricsSample.Entities.Abstract;
using System;

namespace CalculateCodeMetricsSample.Entities.Concrete
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
