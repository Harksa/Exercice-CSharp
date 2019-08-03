using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToDoList.Models
{
    public class Todo
    {
        public int ID { get; set; }

        public string ItemTitle { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
