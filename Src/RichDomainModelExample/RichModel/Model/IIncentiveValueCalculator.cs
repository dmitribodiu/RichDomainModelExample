namespace RichModel.Model
{
    public interface IIncentiveValueCalculator
    {
        int CalculateValue(Trader trader, IncentiveDefinition incentiveDefinition);
    }
}