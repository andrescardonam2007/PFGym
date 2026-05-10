using System;
using System.Collections.Generic;
using System.Text;
using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<I> where I :AuditBase
    {
        Task<IEnumerable<I>> GetAllAsync();

        Task<I?> GetByIdAsync(int id);

        Task<I> CreateAsync(I entity);

        Task UpdateAsync(I entity);

        Task DeleteAsync(int id);

    }
}
