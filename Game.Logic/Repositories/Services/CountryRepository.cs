using System.Collections.Generic;
using System.Threading.Tasks;
using Game.Data;
using Game.Data.Models;
using Game.Logic.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Game.Logic.Repositories.Services
{
    public class CountryRepository : ICountry
    {
        private readonly GamesContext context;

        public CountryRepository(GamesContext _ctx)
        {
            context = _ctx;
        }

        public async Task<bool> AddCountry(Country Model)
        {
            await context.Countries.AddAsync(Model);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            var entity = await context.Countries.FindAsync(id);
            context.Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Country>> GetCountries()
        {
            return await context.Countries.ToListAsync();
        }

        public async Task<Country> GetCountry(int id)
        {
            return await context.Countries.FindAsync(id);
        }

        public async Task<bool> UpdateCountry(Country Model)
        {
            context.Countries.Update(Model);
            await context.SaveChangesAsync();
            return true;
        }
    }
}