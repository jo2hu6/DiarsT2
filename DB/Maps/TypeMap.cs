﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiarsT2.Models;

namespace DiarsT2.DB.Maps
{
    public class TypeMap : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.ToTable("Type");
            builder.HasKey(o => o.Id);

        }
    }
}
