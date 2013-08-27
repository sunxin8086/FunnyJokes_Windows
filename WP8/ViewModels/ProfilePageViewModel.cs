using FunnyJokes.ViewModels;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.ViewModels
{
    public class ProfilePageViewModel : FunnyJokesViewModel
    {
        private string username;

        public ProfilePageViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {
            this.OnNavigatedToCommand = new RelayCommand<IDictionary<string, string>>((query) =>
            {
                this.Profile = null;
                this.username = query["username"];
                this.LoadProfile(username);
            });

            this.SelectPivotCommand = new RelayCommand<int>((index) =>
            {
                if(index == 0)
                {
                    LoadJokes(username);
                }
            });
        }

        private const string IsProfilerogressBarVisiblePropertyName = "IsProfileProgressBarVisible";
        private const string JokesPropertyName = "Jokes";
        private const string ProfilePropertyName = "Profile";

        public bool IsProfileLoaded { get; set; }
        public bool IsJokesLoaded { get; set; }
        public bool isProfilerogressBarVisible = false;
        
        public RelayCommand<int> SelectPivotCommand
        {
            get;
            protected set;
        }

        private IPerson profile;
        public IPerson Profile
        {
            get
            {
                return profile;
            }
            set
            {
                if (profile != value)
                {
                    profile = value;
                    RaisePropertyChanged(ProfilePropertyName);
                }
            }
        }


        public bool IsProfileProgressBarVisible
        {
            get { return isProfilerogressBarVisible; }
            set
            {
                if (isProfilerogressBarVisible != value)
                {
                    isProfilerogressBarVisible = value;
                    RaisePropertyChanged(IsProfilerogressBarVisiblePropertyName);
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

            private set
            {
                if (jokes != value)
                {
                    jokes = value;
                    RaisePropertyChanged(JokesPropertyName);
                }
            }
        }

        public async void LoadProfile(string username)
        {
            this.Profile = await this.funnyJokesDataService.GetProfile(username);
        }

        public async void LoadJokes(string username)
        {
            this.Jokes = await this.funnyJokesDataService.GetJokesByPerson(username);
        }
    }
}
