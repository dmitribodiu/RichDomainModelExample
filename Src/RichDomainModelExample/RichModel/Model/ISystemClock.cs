using System;

namespace RichModel.Model
{
    public interface ISystemClock
    {
        DateTime UtcNow { get; }
        DateTime Now { get; }
    }
}