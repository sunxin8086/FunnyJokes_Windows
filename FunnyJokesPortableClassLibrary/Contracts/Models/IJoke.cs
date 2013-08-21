using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface IJoke
    {
        string Id { get; set; }
        string AuthorId { get; set; }
        string Etag { get; set; }
        string Category { get; set; }
        string Language { get; set; }
        string Title { get; set; }
        string Content { get; set; }
        int LikesNumber { get; set; }
        int DislikesNumber { get; set; }
        int SharesNumber { get; set; }
        int CommentsNumber { get; set; }
        DateTime Updated { get; set; }
        DateTime Created { get; set; }
    }
}
