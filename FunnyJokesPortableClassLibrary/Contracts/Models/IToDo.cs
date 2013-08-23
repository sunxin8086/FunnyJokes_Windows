using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Models
{
    public interface IToDo
    {
        string Icon { set; get; }
        string Todo { set; get; }
    }
}
