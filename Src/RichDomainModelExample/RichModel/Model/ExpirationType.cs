using System;

namespace RichModel.Model
{
    public abstract class ExpirationType
    {
        public abstract DateTime CalculateExpirationDate(IncentiveDefinition incentiveDefinition, ISystemClock systemClock);
    }
}