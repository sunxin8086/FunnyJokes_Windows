using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface ICategory
    {
        string Id { get; set; }
        string Etag { get; set; }
        string ShortName { get; set; }
        string Language { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Count { get; set; }
        bool Hidden { get; set; }
        DateTime Updated { get; set; }
        DateTime Created { get; set; }
    }
}
