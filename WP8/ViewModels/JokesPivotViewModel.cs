using FunnyJokes.ViewModels;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyJokes.ViewModels
{
    public class JokesPivotViewModel : FunnyJokesViewModel
    {
        
        private string shortCategoryName;
        private int days;
        private int page = 1;


        public JokesPivotViewModel(string shortCategoryName, int days, IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {
            this.shortCategoryName = shortCategoryName;
            this.days = days;
        }
        public string PivotName
        {
            get
            {
                switch (days)
                {
                    case 0: return "latest";
                    case 1: return "daily";
                    case 7: return "weekly";
                    case 30: return "monthly";
                    case 300: return "all time";
                    default: return "all time";
                }
            }

        }


        private ObservableCollection<IJoke> jokes;
        public ObservableCollection<IJoke> Jokes
        {
            get
            {
                if (jokes == null)
                    jokes = new ObservableCollection<IJoke>();
                return jokes;
            }
            set
            {
                if (jokes != value)
                {
                    Set(ref jokes, value);
                }
            }
        }

        

        public async void LoadData()
        {
            Jokes.Clear();
            page = 1;
            ObservableCollection<IJoke>  newJokes = await funnyJokesDataService.GetJokesByCategory(shortCategoryName, days, page);
            foreach (IJoke joke in newJokes)
            {
                Jokes.Add(joke);
            }

            page ++;
            this.RaisePropertyChanged("Jokes");
        }

        public async void LoadMoreData()
        {
            ObservableCollection<IJoke> newJokes = await funnyJokesDataService.GetJokesByCategory(shortCategoryName, days, page);
            foreach (IJoke joke in newJokes)
            {
                Jokes.Add(joke);
            }

            page++;
            this.RaisePropertyChanged("Jokes");
        }
    }
}
