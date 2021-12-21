using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;


namespace Family.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string House { get; set; }
        public bool Male { get; set; }      // går inte  att göra nullable?
        public string Title { get; set; }           // evt också flytta title och nummer & epitet till egen tabell
        public string RegnalNumber { get; set; }
        public string RoyalEpithet { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public int? BirthPlace { get; set; }        //koppla till sep. tabell sen
        public int? DeathPlace { get; set; }
        public int? Father { get; set; }
        public int? Mother { get; set; }
    }
}

