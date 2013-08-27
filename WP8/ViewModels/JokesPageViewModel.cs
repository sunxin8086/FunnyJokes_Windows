using FunnyJokes.ViewModels;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyJokes.ViewModels
{
    public class JokesPageViewModel : FunnyJokesViewModel
    {
        public const string CategoryPropertyName = "Category";
        public const string PivotsPropertyName = "Pivots";

        private IDictionary<string, ObservableCollection<JokesPivotViewModel>> cachedPages = new Dictionary<string, ObservableCollection<JokesPivotViewModel>>();

        public JokesPageViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {
            this.OnNavigatedToCommand = new RelayCommand<IDictionary<string, string>>((query) =>
            {
                if (cachedPages.ContainsKey(Category.ShortName))
                {
                    this.Pivots = cachedPages[Category.ShortName];
                }
                else
                {
                    this.Pivots = this.createPivots(Category.ShortName);
                }
            });

            this.SelectPivotCommand = new RelayCommand<int>((index) =>
            {
                JokesPivotViewModel pivot = this.Pivots[(index + 1) % 5];
                pivot.LoadData();
            });
        }

        public RelayCommand<int> SelectPivotCommand
        {
            get;
            protected set;
        }

        public RelayCommand<IJoke> LikeCommand
        {
            get;
            protected set;
        }

        public RelayCommand<IJoke> DislikeCommand
        {
            get;
            protected set;
        }

        public RelayCommand<IJoke> ShareCommand
        {
            get;
            protected set;
        }

        public RelayCommand<IJoke> CommentCommand
        {
            get;
            protected set;
        }

        private ICategory category;
        public ICategory Category
        {
            get
            {
                return category;
            }
            set
            {
                if (category != value)
                {
                    category = value;
                    this.RaisePropertyChanged(CategoryPropertyName);
                }
            }
        }

        private ObservableCollection<JokesPivotViewModel> pivots;
        public ObservableCollection<JokesPivotViewModel> Pivots
        {
            get
            {
                if (pivots == null)
                    pivots = new ObservableCollection<JokesPivotViewModel>();
                return pivots;
            }
            set
            {
                if (pivots != value)
                {
                    pivots = value;
                    this.RaisePropertyChanged(PivotsPropertyName);
                }
            }
        }

        private ObservableCollection<JokesPivotViewModel> createPivots(string shortCategoryName)
        {
            ObservableCollection<JokesPivotViewModel> newPivots = new ObservableCollection<JokesPivotViewModel>();
            newPivots.Add(new JokesPivotViewModel(Category.ShortName, 0, funnyJokesDataService, navigationService));
            newPivots.Add(new JokesPivotViewModel(Category.ShortName, 1, funnyJokesDataService, navigationService));
            newPivots.Add(new JokesPivotViewModel(Category.ShortName, 7, funnyJokesDataService, navigationService));
            newPivots.Add(new JokesPivotViewModel(Category.ShortName, 30, funnyJokesDataService, navigationService));
            newPivots.Add(new JokesPivotViewModel(Category.ShortName, 300, funnyJokesDataService, navigationService));
            this.cachedPages[shortCategoryName] = newPivots;
            return newPivots;
        }

    }
}
