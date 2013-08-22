using FunnyJokesPortableClassLibrary.Contracts.Models;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Models
{
    public class Category : ObservableObject, ICategory
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

        private string shortName;
        [JsonProperty("short_name")]
        public string ShortName
        {
            get { return shortName; }
            set { Set(ref shortName, value); }
        }

        private string language;
        public string Language
        {
            get { return language; }
            set { Set(ref language, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { Set(ref description, value); }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { Set(ref count, value); }
        }

        private bool hidden;
        public bool Hidden
        {
            get { return hidden; }
            set { Set(ref hidden, value); }
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
