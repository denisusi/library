using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data.Models;
using System.Linq;
using System.Text;

namespace Library.Dataa
{
    class LibraryDbContext : DBContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsCOnfigured == false)
            {
                optionsBuilder.UseSqlserver(ConfigurationData.ConnString);
            }
            base.Onconfiguring(optionsBuilder);
        }
        public DbSet<Transport> Transports
        { get; set; }
        public DBSet<LibraryUnits> LiibraryUnits
        { get; set; }
        public DbSet<Title> Titles
        { get; set; }
        public DbSet<Section> Setions
        { get; set; }
        public DbSet<User> Users
        { get; set; }
    }
}