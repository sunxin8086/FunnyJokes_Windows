using FunnyJokesPortableClassLibrary.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Models
{
    public class IndexedPerson : Person, IIndexedPerson
    {
        public IndexedPerson(IPerson p, int index)
        {
            this.Username = p.Username;
            this.JokesNumber = p.JokesNumber;
            this.CommentsNumber = p.CommentsNumber;
            this.LikesNumber = p.LikesNumber;
            this.DislikesNumber = p.DislikesNumber;
            if (String.IsNullOrEmpty(p.ProfileTitle) && String.IsNullOrEmpty(p.ProfileContent))
                this.ProfileTitle = "He is too lazy to write anyting.";
            else
                this.ProfileTitle = String.IsNullOrEmpty(p.ProfileTitle) ? p.ProfileContent : p.ProfileTitle;
            this.ProfileContent = p.ProfileContent;
            this.Created = p.Created;
            this.Updated = p.Updated;
            this.Index = index;
        }

        private int index = 0;
        public int Index
        {
            get { return index; }
            set { Set(ref index, value); }
        }
    }
}
