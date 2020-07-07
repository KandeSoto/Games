using System.Collections.Generic;
using System.Threading.Tasks;
using Game.Data.Models;

namespace Game.Logic.Repositories.Contracts
{
    public interface ICountry
    {
        Task<List<Countries>> GetCountries();
        Task<Countries> GetCountry(int id);
        Task<bool> AddCountry(Countries Model);
        Task<bool> UpdateCountry(Countries Model);
        Task<bool> DeleteCountry(int id);
    }
}