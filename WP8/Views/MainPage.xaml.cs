using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FunnyJokesPortableClassLibrary.Services;
using System.Collections.ObjectModel;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokes.ViewModels;
using FunnyJokes.Services;

namespace WP8.Views
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
         
            test();
        }

        public async void test()
        {
            //FunnyJokesRestDataService s = new FunnyJokesRestDataService();
            //ObservableCollection<IJoke> jokes = await s.GetJokesByCategory("adu_eng", 0, 2);
        }
    }
}