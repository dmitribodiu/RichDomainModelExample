namespace AnemicModel.Model
{
    public interface IOfferValueCalculator
    {
        int CalculateValue(Member member, IncentiveDefinition incentiveDefinition);
    }
}