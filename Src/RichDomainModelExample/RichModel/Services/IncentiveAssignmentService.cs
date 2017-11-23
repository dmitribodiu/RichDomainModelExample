using System;
using RichModel.Model;

namespace RichModel.Services
{
    public class IncentiveAssignmentService
    {
        private readonly ITraderRepository _traderRepository;
        private readonly IIncentiveDefinitionRepository _incentiveDefinitionRepository;
        private readonly IIncentiveValueCalculator _incentiveValueCalculator;
        private readonly IIncentiveRepository _incentiveRepository;
        private readonly ISystemClock _systemClock;

        public IncentiveAssignmentService(
            ITraderRepository traderRepository,
            IIncentiveDefinitionRepository incentiveDefinitionRepository,
            IIncentiveValueCalculator incentiveValueCalculator,
            IIncentiveRepository incentiveRepository,
            ISystemClock systemClock
            )
        {
            _traderRepository = traderRepository;
            _incentiveDefinitionRepository = incentiveDefinitionRepository;
            _incentiveValueCalculator = incentiveValueCalculator;
            _incentiveRepository = incentiveRepository;
            _systemClock = systemClock;
        }

        public void AssignIncentiveToTrader(Guid traderId, Guid incentiveDefinitionId)
        {
            var trader = _traderRepository.GetById(traderId);
            var incentiveDefinition = _incentiveDefinitionRepository.GetById(incentiveDefinitionId);
            
            var incentive = trader.AssignIncentive(incentiveDefinition, _incentiveValueCalculator, _systemClock);
            
            _incentiveRepository.Save(incentive);
        }
    }
}
