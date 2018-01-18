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

        public Nation(string name, int governmentid, int economyid, int capital = 10000, int stability = 100, int resources = 10000,   int id = 0)
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

        //public int GetRandomEvent()
        //{
        //    //1: Market Crash
        //    //2: New Tech Launched
        //}

        //public GetCountryImpact()
        //{
            //int eventId = GetRandomEvent();

            ////if Market crash
            //if (eventId == 1)
            //{
            //    //Capitalism
            //    if (EconomyId == 1)
            //    {
            //        // Capital reduces by 40%
            //        // Resources increase  by 20%
            //        // Stability reduces by 50%
            //    }
            //    //Socialism
            //    else if (EconomyId == 2)
            //    {
            //        // Capital reduces by 20%
            //        // Resources increase by 15%
            //        // Stability reduces by 10%
            //    }
            //} //if New Technology
            //else if(eventId == 2)
            //    {
            //        //if Democracy
            //        if( GovernmentId == 1)
            //        {
            //            // Capital increases by 20%
            //            // Stability increases by 30%
            //            // Resources decrease by 10%
            //        }
            //    //if Socialism
            //    else if (GovernmentId == 2)
            //        {
            //            // Capital increases by 10%
            //            // Stability increases by 10%
            //            // Resources decrease by 5%
            //        }
            //    }
            //}
    }
}
