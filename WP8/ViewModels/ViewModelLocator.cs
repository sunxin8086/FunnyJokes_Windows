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
using WP8.Services;
namespace WP8.ViewModels
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
            SimpleIoc.Default.Register<INavigationService, WP8.Services.NavigationService>();
            SimpleIoc.Default.Register<ILoggingService, LoggingService>();
            SimpleIoc.Default.Register<IFunnyJokesDataService, FunnyJokesRestDataService>();
            SimpleIoc.Default.Register<MainPageViewModel>();
        }

        public MainPageViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }
    }
}
