using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokesPortableClassLibrary.Models;
using Microsoft.Practices.ServiceLocation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FunnyJokesPortableClassLibrary.Services
{
    public class FunnyJokesRestDataService : IFunnyJokesDataService
    {
        private static readonly string serverAddress = "http://198.199.100.186:8888/xinsun/v1/";
        private static readonly string jokesResource = "jokes";
        private static readonly string peopleResource = "people";
        private static readonly string commentsResource = "people";
        private static readonly string likesResource = "likes";
        private static readonly string categoriesResource = "categories";
        private static readonly string serverDateFormat = "yyyy-MM-dd hh:mm:ss";

        private const int defaultPageSize = 25;
        private static readonly int topJokersNumber = 9;
        private static readonly int categoriesPageSize = 50;

        private ILoggingService logger;

        private static readonly int maxDays = 365 * 3;
        HttpClient http = new HttpClient() { BaseAddress = new Uri(serverAddress) };

        public FunnyJokesRestDataService()
        {
            //this.logger = ServiceLocator.Current.GetInstance<ILoggingService>();
        }

        public async Task<ObservableCollection<IJoke>> GetJokesByCategory(string category, int days = 0, int page = 1)
        {
            string where = string.Format("\"category\" : \"{0}\"", category);
            string dayRange = getDayRangeFromDays(days);
            if (dayRange!= null)
                where = where + ", " + dayRange;
            where = string.Format("{{{0}}}", where);

            string sort = string.Empty;
            if (days > 0)
                sort = "[(\"likes_number\" , -1)]";
            else
                sort = "[(\"created\" , -1)]";

            List<Joke> items = await this.getResource<Joke>(jokesResource, where, sort, defaultPageSize, page);
            ObservableCollection<IJoke> jokes = new ObservableCollection<IJoke>();
            foreach (Joke joke in items)
            {
                jokes.Add(joke);
            }
            return jokes;
        }

        public async Task<ObservableCollection<ICategory>> GetCategories()
        {
            List<Category> items = await this.getResource<Category>(categoriesResource, "", "", categoriesPageSize);
            ObservableCollection<ICategory> categories = new ObservableCollection<ICategory>();
            foreach (Category category in items)
            {
                categories.Add(category);
            }
            return categories;
        }

        public async Task<ObservableCollection<IPerson>> GetTopJokers()
        {
            string sort = "[(\"jokes_number\" , -1)]";
            List<Person> items = await this.getResource<Person>(peopleResource, "", "", topJokersNumber);
            ObservableCollection<IPerson> people = new ObservableCollection<IPerson>();
            foreach (Person person in items)
            {
                people.Add(person);
            }
            return people;
        }
        
        public async Task<ObservableCollection<IComment>> GetComments(string jokeId)
        {
            return null;
        }

        private async Task<List<T>> getResource<T>(string resource, string where, string sort, int pageSize = defaultPageSize, int page = 1)
        {
            String uri = String.Format("{0}?where={1}&sort={2}&max_results={3}&page={4}", resource, where, sort, pageSize, page);
            var json = await http.GetStringAsync(uri);//.Result;
            //response.EnsureSuccessStatusCode();
            //string json = await response.Content.ReadAsStringAsync();
            //this.logger.Debug(json);
            JObject rootObject = JObject.Parse(json);
            var items = rootObject["_items"];
            List<T> jokes = items.ToObject<List<T>>();
            return jokes;
        }

        private string getDayRangeFromDays(int days = 0)
        {
            days = days < maxDays ? days : maxDays;
            if (days == 0)
                return null;

            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(-days);

            string startStr = start.ToString(serverDateFormat);
            string endStr = end.ToString(serverDateFormat);

            return String.Format("\"created\" : {{\"$lt\" : \"{0}\", \"$gt\" : \"{1}\"}}", startStr, endStr); 
        }
    }
}
