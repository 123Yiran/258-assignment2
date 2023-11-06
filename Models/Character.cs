using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment2.Models
{
    public class Character
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Faction { get; set; }
        public string Attribute { get; set; }
        public string ImagePath { get; set; }
        public int? DestinyID { get; set; }
        public virtual Destiny Destiny { get; set; }
    }
}