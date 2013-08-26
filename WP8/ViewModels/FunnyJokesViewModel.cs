using FunnyJokesPortableClassLibrary.Contracts.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FunnyJokes.ViewModels
{
    public class FunnyJokesViewModel : ViewModelBase
    {
        protected IFunnyJokesDataService funnyJokesDataService;
        protected INavigationService navigationService;

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

        public bool LightThemeEnabled
        {
            get
            {
                return (Visibility)Application.Current.Resources["PhoneLightThemeVisibility"] == Visibility.Visible;
            }
        }

        protected override void RaisePropertyChanged(string propertyName)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() => base.RaisePropertyChanged(propertyName));
        }
        protected override void RaisePropertyChanged<T>(string propertyName, T oldValue, T newValue, bool broadcast)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() => base.RaisePropertyChanged<T>(propertyName, oldValue, newValue, broadcast));
        }
    }
}
