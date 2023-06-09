﻿namespace MovieManagerMVC.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T actor);
        Task UpdateAsync(int id, T newActor);
        Task DeleteAsync(int id);
    }
}
