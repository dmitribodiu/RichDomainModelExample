using System;

namespace AnemicModel.Model
{
    public interface ITraderRepository
    {
        Trader GetById(Guid id);
    }
}