using FunnyJokes.ViewModels;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8
{
    public class FunnyJokesBasePage : PhoneApplicationPage
    {
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            FunnyJokesViewModel vm = this.DataContext as FunnyJokesViewModel;
            if (vm.OnNavigatedToCommand != null)
            {
                vm.OnNavigatedToCommand.Execute(base.NavigationContext.QueryString);
            }
        }

        protected override void OnNavigatingFrom(System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            FunnyJokesViewModel vm = this.DataContext as FunnyJokesViewModel;
            if (vm.OnNavigatingFromCommand != null)
            {
                vm.OnNavigatingFromCommand.Execute(null);
            }
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            FunnyJokesViewModel vm = this.DataContext as FunnyJokesViewModel;
            if (vm.OnNavigatingFromCommand != null)
            {
                vm.OnNavigatingFromCommand.Execute(null);
            }
        }
    }
}
