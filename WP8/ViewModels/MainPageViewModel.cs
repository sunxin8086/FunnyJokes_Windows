using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokesPortableClassLibrary.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FunnyJokes.ViewModels
{
    public class MainPageViewModel : FunnyJokesViewModel
    {
        private string language;
        private ObservableCollection<ICategory> categories;
        private ObservableCollection<IIndexedPerson> topJokers;
        private ObservableCollection<IToDo> todos;

        public const string LanguagePropertyName = "Language";
        public const string CategoriesPropertyName = "Categories";
        public const string TopJokersPropertyName = "TopJokers";
        public const string TodosPropertyName = "Todos";

        public MainPageViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {
            this.Todos = new ObservableCollection<IToDo>();
            this.Todos.Add(new ToDo(null, "add a joke"));
            this.Todos.Add(new ToDo(null, "suggest a category"));
            this.Todos.Add(new ToDo(null, "emaill your feedback"));
            this.Todos.Add(new ToDo(null, "rate this app"));
            this.Todos.Add(new ToDo(null, "my profile"));
            this.Todos.Add(new ToDo(null, "setting"));
            this.LoadCategories();
            this.LoadTopJokers();
        }

        public string Language
        {
            get { return language; }
            set
            {
                if (language != value)
                {
                    language = value;
                    this.RaisePropertyChanged(LanguagePropertyName);
                }
            }
        }

        public ObservableCollection<ICategory> Categories
        {
            get { return categories; }
            set
            {
                if (categories != value)
                {
                    categories = value;
                    this.RaisePropertyChanged(CategoriesPropertyName);
                }
            }
        }

        public ObservableCollection<IIndexedPerson> TopJokers
        {
            get
            {
                if (topJokers == null)
                    topJokers = new ObservableCollection<IIndexedPerson>();
                return topJokers;
            }
            set
            {
                if (topJokers != value)
                {
                    topJokers = value;
                    this.RaisePropertyChanged(TopJokersPropertyName);
                }
            }
        }

        public ObservableCollection<IToDo> Todos
        {
            get { return todos; }
            set
            {
                if (todos != value)
                {
                    todos = value;
                    this.RaisePropertyChanged(TopJokersPropertyName);
                }
            }
        }

        public async void LoadCategories()
        {
            var t = funnyJokesDataService.GetCategories();
            t.ContinueWith(task =>
            {
                this.Categories = t.Result;
            });
        }

        public void LoadTopJokers()
        {
            var t = funnyJokesDataService.GetTopJokers();
            t.ContinueWith(task =>
            {
                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    int i = 1;
                    foreach (IPerson p in t.Result)
                    {
                        this.TopJokers.Add(new IndexedPerson(p, i));
                        i++;
                    }
                });
            });
        }

        //public void LoadMessages();*/


        #region Images
        public string AddJokeImage
        {
            get
            {
                return "/Images/{0}/add.png";
            }
        }

        public string BulbImage
        {
            get
            {
                return "/Images/{0}/bulb.png";
            }
        }

        public string EmailImage
        {
            get
            {
                return "/Images/{0}/email.png";
            }
        }

        public string ProfileImage
        {
            get
            {
                return "/Images/{0}/profile.png";
            }
        }

        public string SignImage
        {
            get
            {
                return "/Images/{0}/sign.png";
            }
        }

        public string RateImage
        {
            get
            {
                return "/Images/{0}/rate.png";
            }
        }

        public string SettingImage
        {
            get
            {
                return "/Images/{0}/setting.png";
            }
        }
        #endregion
    }
}
