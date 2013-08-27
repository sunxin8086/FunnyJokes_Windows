using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokesPortableClassLibrary.Services;
using FunnyJokes.Services;
using WP8.ViewModels;
namespace FunnyJokes.ViewModels
{
   /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<INavigationService, FunnyJokes.Services.NavigationService>();
            SimpleIoc.Default.Register<ILoggingService, LoggingService>();
            SimpleIoc.Default.Register<IFunnyJokesDataService, FunnyJokesRestDataService>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<JokesPageViewModel>();
            SimpleIoc.Default.Register<JokePageViewModel>();
            SimpleIoc.Default.Register<ProfilePageViewModel>();
        }

        public MainPageViewModel MainVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }

        public JokesPageViewModel JokesPageVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<JokesPageViewModel>();
            }
        }

        public JokePageViewModel JokePageVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<JokePageViewModel>();
            }
        }

        public ProfilePageViewModel ProfilePageVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProfilePageViewModel>();
            }
        }
    }
}
