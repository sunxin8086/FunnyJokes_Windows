using FunnyJokes.ViewModels;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.ViewModels
{
    public class JokePageViewModel : FunnyJokesViewModel
    {
        public const string CommentsPropertyName = "Comments";
        public const string IsLikeProgressBarVisiblePropertyName = "IsLikeProgressBarVisible";

        public bool IsLikeStatusLoaded { private set; get; }
        public IJoke CurrentJoke { set; get; }
        public ILike LikeStatus { set; get; }

        public JokePageViewModel(IFunnyJokesDataService funnyJokesDataService, INavigationService navigationService)
            : base(funnyJokesDataService, navigationService)
        {

        }
        
        private ObservableCollection<IComment> _comments;
        public ObservableCollection<IComment> Comments
        {
            get
            {
                if (_comments == null)
                    _comments = new ObservableCollection<IComment>();
                return _comments;
            }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    RaisePropertyChanged("CommentsPropertyName");
                }
            }
        }

        public bool isLikeProgressBarVisible = false;
        public bool IsLikeProgressBarVisible
        {
            get { return isLikeProgressBarVisible; }
            set
            {
                if (isLikeProgressBarVisible != value)
                {
                    isLikeProgressBarVisible = value;
                    RaisePropertyChanged(IsLikeProgressBarVisiblePropertyName);
                }
            }
        }
    }
}
