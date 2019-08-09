using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToDoList.Models
{
    public class Todo
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string ItemTitle { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
