using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Contracts.Services;
using FunnyJokesPortableClassLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FunnyJokesPortableClassLibrary.Services
{
    public class FunnyJokesRestDataService : IFunnyJokesDataService
    {

        public async Task<List<IJoke>> getJokesByCategory(string category, int days = 0, int page = 1)
        {
            HttpClient http = new HttpClient();
            string Json = await http.GetStringAsync("http://198.199.100.186:8888/xinsun/v1/jokes/1");


            Joke joke = JsonConvert.DeserializeObject<Joke>(Json);

            //string Json1 = await http.GetStringAsync("http://yourjavascript.com/0192177313/1.js");
            //RootObject Test = JsonConvert.DeserializeObject<RootObject>(Json1);

            return null;
        }
    }
}
