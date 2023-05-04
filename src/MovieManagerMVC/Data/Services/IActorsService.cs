﻿using MovieManagerMVC.Models;

namespace MovieManagerMVC.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}
