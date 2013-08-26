﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Services
{
    public interface INavigationService
    {
        void Navigate(Type sourcePageType);
        void Navigate(Type sourcePageType, object parameter);
        void NavigateTo(Uri pageUri);
        void GoBack();
    }
}
