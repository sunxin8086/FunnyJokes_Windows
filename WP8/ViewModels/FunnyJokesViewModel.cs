using FunnyJokesPortableClassLibrary.Contracts.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.ViewModels
{
    public class FunnyJokesViewModel : ViewModelBase
    {
        private IFunnyJokesDataService funnyJokesDataService;
        private INavigationService navigationService;

        public FunnyJokesViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
        {
            this.funnyJokesDataService = funnyJokesDataService;
            this.navigationService = navigationService;
        }

        public RelayCommand NavigateToPersonPageCommand
        {
            get;
            private set;
        }

        public RelayCommand NavigateToCategoryPageCommand
        {
            get;
            private set;
        }

        public RelayCommand NavigateToJokePageCommand
        {
            get;
            private set;
        }

        public RelayCommand NavigateToHelpPageCommand
        {
            get;
            private set;
        }

        public RelayCommand NavigateToSettingPageCommand
        {
            get;
            private set;
        }
    }
}
