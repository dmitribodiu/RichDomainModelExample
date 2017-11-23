using System;

namespace AnemicModel.Model
{
    public interface IIncentiveDefinitionRepository
    {
        IncentiveDefinition GetById(Guid id);
    }
}