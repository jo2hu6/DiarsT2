using DiarsT2.DB.Maps;
using DiarsT2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT2.DB
{
    public class AppPokemonContext : DbContext
    {
        public DbSet<Type> Tipos { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<UserPokemon> UsuarioPokemons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JOSUERIVERA\\SQLEXPRESS;Database=DiarsT2;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PokemonMap());
            modelBuilder.ApplyConfiguration(new TypeMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserPokemonMap());
        }
    }
}
