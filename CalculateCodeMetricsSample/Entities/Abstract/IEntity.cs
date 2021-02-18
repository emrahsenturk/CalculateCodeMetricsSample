using System;

namespace CalculateCodeMetricsSample.Entities.Abstract
{
    public interface IEntity<TId>
        where TId : IEquatable<TId>
    {
        TId Id { get; set; }
    }
}
