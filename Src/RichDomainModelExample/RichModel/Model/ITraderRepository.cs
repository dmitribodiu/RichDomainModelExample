using System;

namespace RichModel.Model
{
    public interface ITraderRepository
    {
        Trader GetById(Guid id);
    }
}