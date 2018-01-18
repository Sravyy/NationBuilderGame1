using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace NationBuilderGame.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capital { get; set; }
        public int Stability { get; set; }
        public int Resources { get; set; }

        public int GovernmentId { get; set; }
        public int EconomyId { get; set; }

        public Nation(string name, int capital = 10000, int stability = 100, int resources = 10000, int governmentid, int economyid,  int id = 0)
        {
            Name = name;
            Capital = capital;
            Stability = stability;
            Resources = resources;
            GovernmentId = governmentid;
            EconomyId = economyid;
            Id = id;
        }

        public Nation()
        {
        }
    }
}
