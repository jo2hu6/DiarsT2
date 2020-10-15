using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT2.Models
{
    public class UserPokemon
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public DateTime Date { get; set; }
    }
}
