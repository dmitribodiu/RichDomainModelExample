using System;

namespace AnemicModel.Model
{
    public interface IOfferTypeRepository
    {
        OfferType GetById(Guid id);
    }
}