using FunnyJokesPortableClassLibrary.Contracts.Models;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Models
{
    public class Like : ObservableObject, ILike
    {
        private string id;
        [JsonProperty("_id")]
        public string Id
        {
            get { return id; }
            set { Set(ref id, value); }
        }

        private string etag;
        public string Etag
        {
            get { return etag; }
            set { Set(ref etag, value); }
        }

        private string jokeId;
        [JsonProperty("joke_id")]
        public string JokeId
        {
            get { return jokeId; }
            set { Set(ref jokeId, value); }
        }

        private string authorId;
        [JsonProperty("author_id")]
        public string AuthorId
        {
            get { return authorId; }
            set { Set(ref authorId, value); }
        }


        private bool liked;
        public bool Liked
        {
            get { return liked; }
            set { Set(ref liked, value); }
        }

        private DateTime updated;
        public DateTime Updated
        {
            get { return updated; }
            set { Set(ref updated, value); }
        }

        private DateTime created;
        public DateTime Created
        {
            get { return created; }
            set { Set(ref created, value); }
        }
    }
}
