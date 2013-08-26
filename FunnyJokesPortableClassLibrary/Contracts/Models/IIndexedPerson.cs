using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface IIndexedPerson : IPerson
    {
        int Index { set; get; }
    }
}
