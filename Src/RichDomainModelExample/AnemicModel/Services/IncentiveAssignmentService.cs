using System;
using AnemicModel.Model;

namespace AnemicModel.Services
{
    public class IncentiveAssignmentService
    {
        private readonly ITraderRepository _traderRepository;
        private readonly IIncentiveDefinitionRepository _incentiveDefinitionRepository;
        private readonly IIncentiveValueCalculator _incentiveValueCalculator;
        private readonly IIncentiveRepository _incentiveRepository;

        public IncentiveAssignmentService(
            ITraderRepository traderRepository,
            IIncentiveDefinitionRepository incentiveDefinitionRepository,
            IIncentiveValueCalculator incentiveValueCalculator,
            IIncentiveRepository incentiveRepository
            )
        {
            _traderRepository = traderRepository;
            _incentiveDefinitionRepository = incentiveDefinitionRepository;
            _incentiveValueCalculator = incentiveValueCalculator;
            _incentiveRepository = incentiveRepository;
        }

        public void AssignIncentive(Guid traderId, Guid incentiveDefinitionId)
        {
            var trader = _traderRepository.GetById(traderId);
            var incentiveDefinition = _incentiveDefinitionRepository.GetById(incentiveDefinitionId);
            var incentiveValue = _incentiveValueCalculator.CalculateValue(trader, incentiveDefinition);

            DateTime dateExpiring;
            switch (incentiveDefinition.ExpirationType)
            {
                case ExpirationType.Assignment:
                    dateExpiring = DateTime.Now.AddDays(incentiveDefinition.DaysValid);
                    break;
                case ExpirationType.Fixed:
                    if (incentiveDefinition.BeginDate != null)
                    {
                        dateExpiring = incentiveDefinition.BeginDate.Value.AddDays(incentiveDefinition.DaysValid);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var incentive = new Incentive
            {
                TraderAssigned = trader,
                IncentiveDefinition = incentiveDefinition,
                Value = incentiveValue,
                DateExpiring = dateExpiring
            };
            trader.AssignedIncentives.Add(incentive);
            trader.NumberOfAssignedIncentives++;

            _incentiveRepository.Save(incentive);
        }
    }
}
