﻿using System;

namespace AnemicModel.Model
{
    public interface IOfferTypeRepository
    {
        IncentiveDefinition GetById(Guid id);
    }
}