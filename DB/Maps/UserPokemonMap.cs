using DiarsT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT2.DB.Maps
{
    public class UserPokemonMap : IEntityTypeConfiguration<UserPokemon>
    {
        public void Configure(EntityTypeBuilder<UserPokemon> builder)
        {
            builder.ToTable("UserPokemon");
            builder.HasKey(o => new { o.PokemonId, o.UserId });
            builder.HasOne(o => o.User).WithMany(o => o.PokemonesCapturados).HasForeignKey(o => o.UserId);
            builder.HasOne(o => o.Pokemon).WithMany(o => o.Users).HasForeignKey(o => o.PokemonId);
        }
    }
}
