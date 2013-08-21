namespace FunnyJokesPortableClassLibrary.Models
{
    using FunnyJokesPortableClassLibrary.Contracts.Models;
    using GalaSoft.MvvmLight;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Joke : ObservableObject, IJoke
    {
        private string id;
        [JsonProperty("_id")]
        public string Id 
        {
            get { return id; }
            set { Set(ref id, value); }
        }

        private string authorId;
        [JsonProperty("author_id")]
        public string AuthorId
        {
            get { return authorId; }
            set { Set(ref authorId, value); }
        }

        private string etag;
        public string Etag
        {
            get { return etag; }
            set { Set(ref etag, value); }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { Set(ref category, value); }
        }

        private string language;
        public string Language
        {
            get { return language; }
            set { Set(ref language, value); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set { Set(ref content, value); }
        }

        private int likesNumber;
        [JsonProperty("likes_number")]
        public int LikesNumber
        {
            get { return likesNumber; }
            set { Set(ref likesNumber, value); }
        }

        private int dislikesNumber;
        [JsonProperty("dislikes_number")]
        public int DislikesNumber
        {
            get { return dislikesNumber; }
            set { Set(ref dislikesNumber, value); }
        }

        private int commentsNumber;
        [JsonProperty("comments_number")]
        public int CommentsNumber
        {
            get { return commentsNumber; }
            set { Set(ref commentsNumber, value); }
        }

        private int sharesNumber;
        [JsonProperty("shares_number")]
        public int SharesNumber
        {
            get { return sharesNumber; }
            set { Set(ref sharesNumber, value); }
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
