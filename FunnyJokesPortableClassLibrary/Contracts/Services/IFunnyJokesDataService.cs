using FunnyJokesPortableClassLibrary.Contracts.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FunnyJokesPortableClassLibrary.Contracts.Services
{
    public interface IFunnyJokesDataService
    {
        Task<ObservableCollection<IJoke>> getJokesByCategory(string category, int days = 0, int page = 1);
    }
}
