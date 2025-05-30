﻿using System.Data.Entity;
using SimpleSocialNetwork.Data.EntityConfigurations;
using SimpleSocialNetwork.Models;

namespace SimpleSocialNetwork.Data.DbContexts
{
    public class SimpleSocialNetworkDbContext : DbContext
    {
        public SimpleSocialNetworkDbContext() : base("Data Source=HYTE-Y-60;Initial Catalog=SimpleSocialNetwork;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfigProfile());
            modelBuilder.Configurations.Add(new ConfigFeed());
            modelBuilder.Configurations.Add(new ConfigLike());
        }

        public DbSet<ModelProfile> profiles { get; set; }
        public DbSet<ModelFeed> feed { get; set; }
        public DbSet<ModelLike> likes { get; set; }
    }
}