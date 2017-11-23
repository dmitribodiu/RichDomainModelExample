using System;

namespace RichModel.Model
{
    public interface IIncentiveDefinitionRepository
    {
        IncentiveDefinition GetById(Guid id);
    }
}