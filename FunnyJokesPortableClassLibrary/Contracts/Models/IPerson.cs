using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface IPerson
    {
        string Id { get; set; }
        string Etag { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        bool Sex { get; set; }
        DateTime Birthday { get; set; }
        string ProfileTitle { get; set; }
        string ProfileContent { get; set; }
        int JokesNumber { get; set; }
        int CommentsNumber { get; set; }
        int LikesNumber { get; set; }
        int DislikesNumber { get; set; }
        DateTime Updated { get; set; }
        DateTime Created { get; set; }
    }
}
