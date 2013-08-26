using FunnyJokesPortableClassLibrary.Contracts.Services;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace FunnyJokes.Services
{
    public class NavigationService : INavigationService
    {
        private PhoneApplicationFrame mainFrame;
        public event NavigatingCancelEventHandler Navigating;

        public void Navigate(Type sourcePageType)
        {

        }
        public void Navigate(Type sourcePageType, object parameter)
        {

        }

        public void NavigateTo(Uri pageUri)
        {
            if (EnsureMainFrame())
            {
                mainFrame.Navigate(pageUri);
            }
        }

        public void GoBack()
        {
            if (EnsureMainFrame() && mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }
        }

        private bool EnsureMainFrame()
        {

            if (mainFrame != null)
            {
                return true;
            }

            mainFrame = Application.Current.RootVisual as PhoneApplicationFrame;

            if (mainFrame != null)
            {
                // Could be null if the app runs inside a design tool
                mainFrame.Navigating += (s, e) =>
                {
                    if (Navigating != null)
                    {
                        Navigating(s, e);
                    }
                };
                return true;
            }
            return false;
        }

    }
}
