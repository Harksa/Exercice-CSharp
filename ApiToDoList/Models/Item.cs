using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToDoList.Models
{
    public class Item
    {
        public int ID { get; set; }

        public string Objectif { get; set; }

        public virtual Todo TodoList { get; set; }
    }

}


