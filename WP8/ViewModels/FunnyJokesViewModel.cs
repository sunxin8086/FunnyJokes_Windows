using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WP8.ViewModels;
using WP8.Views;

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

            this.NavigateToCategoryJokesPageCommand = new RelayCommand<ICategory>((category)=>
            {
                JokesPageViewModel vm = ServiceLocator.Current.GetInstance<JokesPageViewModel>();
                vm.Category = category;
                vm.Pivots = null;
                this.navigationService.NavigateTo(new Uri("/Views/JokesPage.xaml", UriKind.RelativeOrAbsolute));
            });

            this.NavigateToJokePageCommand = new RelayCommand<IJoke>((joke) =>
            {
                JokePageViewModel vm = ServiceLocator.Current.GetInstance<JokePageViewModel>();
                vm.CurrentJoke = joke;
                this.navigationService.NavigateTo(new Uri("/Views/JokePage.xaml", UriKind.RelativeOrAbsolute));
            });

            this.NavigateToProfilePageCommand = new RelayCommand<string>((username) =>
            {
                ProfilePageViewModel vm = ServiceLocator.Current.GetInstance<ProfilePageViewModel>();
                this.navigationService.NavigateTo(new Uri("/Views/ProfilePage.xaml?username=1", UriKind.RelativeOrAbsolute));
            });
        }

        public RelayCommand<IDictionary<string, string>> OnNavigatedToCommand
        {
            get;
            protected set;
        }

        public RelayCommand OnNavigatedFromCommand
        {
            get;
            protected set;
        }

        public RelayCommand OnNavigatingFromCommand
        {
            get;
            protected set;
        }

        public RelayCommand LoadedCommand
        {
            get;
            protected set;
        }

        public RelayCommand<string> NavigateToProfilePageCommand
        {
            get;
            protected set;
        }

        public RelayCommand NavigateToCategoryPageCommand
        {
            get;
            protected set;
        }

        public RelayCommand<IJoke> NavigateToJokePageCommand
        {
            get;
            protected set;
        }

        public RelayCommand<ICategory> NavigateToCategoryJokesPageCommand
        {
            get;
            protected set;
        }

        public RelayCommand NavigateToHelpPageCommand
        {
            get;
            protected set;
        }

        public RelayCommand NavigateToSettingPageCommand
        {
            get;
            protected set;
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
