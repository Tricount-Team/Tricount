﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.EntityConfigurations.Abstract;
using Tricount.Entities.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.EntityConfigurations.Concrete
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
<<<<<<< HEAD
            
=======
           
            builder.Property(p => p.TCNO).HasMaxLength(11);
            builder.HasIndex(p=>p.TCNO).IsUnique();
>>>>>>> Test
        }
    }
}
