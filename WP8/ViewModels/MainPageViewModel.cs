using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokesPortableClassLibrary.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.ViewModels
{
    public class MainPageViewModel : FunnyJokesViewModel
    {
        private string language;
        private ObservableCollection<ICategory> categories;
        private ObservableCollection<IPerson> topJokers;
        private ObservableCollection<IToDo> todos;

        public const string LanguagePropertyName = "Language";
        public const string CategoriesPropertyName = "Categories";
        public const string TopJokersPropertyName = "TopJokers";
        public const string TodosPropertyName = "Todos";

        public MainPageViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {
            /*this.Todos = new ObservableCollection<IToDo>();
            this.Todos.Add(new ToDo(null, "add a joke"));
            this.Todos.Add(new ToDo(null, "suggest a category"));
            this.Todos.Add(new ToDo(null, "emaill your feedback"));
            this.Todos.Add(new ToDo(null, "rate this app"));
            this.Todos.Add(new ToDo(null, "my profile"));
            this.Todos.Add(new ToDo(null, "setting"));*/
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

        public ObservableCollection<IPerson> TopJokers
        {
            get { return topJokers; }
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
    }
}
