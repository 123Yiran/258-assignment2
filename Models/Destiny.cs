using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment2.Models
{
    public class Destiny
    {
        

        [Key]
        public int ID { get; set; }

        [Display(Name ="Destiny Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsInverted { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}