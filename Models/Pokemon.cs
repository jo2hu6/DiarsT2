using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiarsT2.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Type")]
        public int TypeId {get; set;}
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Type Type { get; set; }
        public List<UserPokemon> Users { get; set; }
    }
}
