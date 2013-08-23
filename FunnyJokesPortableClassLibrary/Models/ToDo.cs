using FunnyJokesPortableClassLibrary.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Models
{
    public class ToDo : IToDo
    {
        public string Icon { set; get; }
        public string Todo { set; get; }

        public ToDo(string icon, string todo)
        {
            this.Icon = icon;
            this.Todo = todo;
        }
    }
}
