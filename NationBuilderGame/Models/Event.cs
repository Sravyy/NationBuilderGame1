using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace NationBuilderGame.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public Event(string name, int id = 0)
        {
            Name = name;
            Id = id;
        }

    }
}
