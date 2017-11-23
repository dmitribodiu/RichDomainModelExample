using System;

namespace AnemicModel.Model
{
    public interface IMemberRepository
    {
        Member GetById(Guid id);
    }
}