using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCodeMetricsSample.Entities.Concrete
{
    public class Lesson : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
