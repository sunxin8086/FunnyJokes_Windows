using FunnyJokesPortableClassLibrary.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunnyJokesPortableClassLibrary.Contracts.Services
{
    public interface IFunnyJokesDataService
    {
        Task<List<IJoke>> getJokesByCategory(string category, int days = 0, int page = 1);
    }
}
