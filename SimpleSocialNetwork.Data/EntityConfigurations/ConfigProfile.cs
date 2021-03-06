﻿using System.Data.Entity.ModelConfiguration;
using SimpleSocialNetwork.Models;

namespace SimpleSocialNetwork.Data.EntityConfigurations
{
    public class ConfigProfile : EntityTypeConfiguration<ModelProfile>
    {
        public ConfigProfile()
        {
            ToTable("profiles");
            Property(user => user.Id).HasColumnName("id");
            HasKey(user => user.Id);
            Property(user => user.Name).HasColumnName("name");
            Property(user => user.Password).HasColumnName("password_hash");
            Property(user => user.Token).HasColumnName("token");
            Property(user => user.DateAdd).HasColumnName("date_add");
        }
    }
}