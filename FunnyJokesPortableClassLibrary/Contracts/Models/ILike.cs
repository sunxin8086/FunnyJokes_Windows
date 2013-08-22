using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface ILike
    {
        string Id { get; set; }
        string Etag { get; set; }
        string JokeId { get; set; }
        string AuthorId { get; set; }
        bool Liked { get; set; }
        DateTime Updated { get; set; }
        DateTime Created { get; set; }
    }
}
