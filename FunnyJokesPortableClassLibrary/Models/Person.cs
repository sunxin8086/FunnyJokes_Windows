using FunnyJokesPortableClassLibrary.Contracts.Models;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Models
{
    public class Person : ObservableObject, IPerson
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

        private string username;
        public string Username
        {
            get { return username; }
            set { Set(ref username, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }

        private string accountType;
        [JsonProperty("account_type")]
        public string AccountType
        {
            get { return accountType; }
            set { Set(ref accountType, value); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { Set(ref email, value); }
        }

        private bool sex;
        public bool Sex
        {
            get { return sex; }
            set { Set(ref sex, value); }
        }

        private string profileTitle;
        [JsonProperty("profile_title")]
        public string ProfileTitle
        {
            get { return profileTitle; }
            set { Set(ref profileTitle, value); }
        }

        private string profileContent;
        [JsonProperty("profile_content")]
        public string ProfileContent
        {
            get { return profileContent; }
            set { Set(ref profileContent, value); }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set { Set(ref birthday, value); }
        }

        private int jokesNumber;
        [JsonProperty("jokes_number")]
        public int JokesNumber
        {
            get { return jokesNumber; }
            set { Set(ref jokesNumber, value); }
        }

        private int commentsNumber;
        [JsonProperty("comments_number")]
        public int CommentsNumber
        {
            get { return commentsNumber; }
            set { Set(ref commentsNumber, value); }
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
