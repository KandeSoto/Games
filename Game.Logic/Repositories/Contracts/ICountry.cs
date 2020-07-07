using System.Collections.Generic;
using System.Threading.Tasks;
using Game.Data.Models;

namespace Game.Logic.Repositories.Contracts
{
    public interface ICountry
    {
        Task<List<Country>> GetCountries();
        Task<Country> GetCountry(int id);
        Task<bool> AddCountry(Country Model);
        Task<bool> UpdateCountry(Country Model);
        Task<bool> DeleteCountry(int id);
    }
}