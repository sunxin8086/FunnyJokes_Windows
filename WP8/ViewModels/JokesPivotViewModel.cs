using FunnyJokes.ViewModels;
using FunnyJokesPortableClassLibrary.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.ViewModels
{
    public class JokesPivotViewModel : FunnyJokesViewModel
    {
        public string DurationName { get; set; }
        private string shortCategory;
        private int days;

        public JokesPivotViewModel(int days)
        {
            this.DurationName = DurationName;
            switch (DurationName)
            {
                case "latest":
                    days = 1001;
                    break;
                case "daily":
                    days = 1;
                    break;
                case "weekly":
                    days = 7;
                    break;
                case "monthly":
                    days = 30;
                    break;
                case "all":
                    days = 999;
                    break;
                default:
                    days = 1;
                    break;
            }
        }
        private ObservableCollection<IJoke> jokes;
        public ObservableCollection<IJoke> Jokes
        {
            get
            {
                if (jokes == null)
                    jokes = new ObservableCollection<IJoke>();
                return jokes;
            }
            set
            {
                if (jokes != value)
                {
                    Set(ref jokes, value);
                }
            }
        }

        

        public void LoadData()
        {
            this.IsProgressBarVisible = true;
            Jokes.Clear();
            jokesContext.Page = 0;
            service.GetJokesByTimeAsync(ShortCategory, days, jokesContext.Page, jokesContext.Size);
        }

        public void LoadMoreData()
        {
            if (this.Jokes != null && this.jokesContext.Continuation && !this.IsProgressBarVisible)
            {
                this.IsProgressBarVisible = true;
                service.GetJokesByTimeAsync(ShortCategory, days, jokesContext.Page, jokesContext.Size);
            }
        }

        void jokes_LoadCompleted(object sender, GetJokesByTimeCompletedEventArgs e)
        {
            this.IsProgressBarVisible = false;
            if (e.Error == null)
            {
                foreach (Joke joke in e.Result)
                {
                    Jokes.Add(joke);
                }
                jokesContext.Page++;
                jokesContext.Continuation = e.Result.Count == jokesContext.Size;
                this.NotifyPropertyChanged("Jokes");

            }
            else
                MessageBox.Show(string.Format("An error has occured: {0}", e.Error.Message));
        }
    }
}
