using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToDoList.Models
{
    public class Item
    {
        public int TodoId { get; set; }

        public Todo Todo { get; set; }

        public int ItemId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Objectif { get; set; }

        public bool IsDone { get; set; }
    }

}


