using System;

namespace RichModel.Model
{
    public class FixedExpiring : ExpirationType
    {
        private readonly DateTime _beginDate;

        public FixedExpiring(DateTime beginDate)
        {
            _beginDate = beginDate;
        }

        public override DateTime CalculateExpirationDate(IncentiveDefinition incentiveDefinition, ISystemClock systemClock)
        {
            return _beginDate.AddDays(incentiveDefinition.DaysValid);
        }
    }
}