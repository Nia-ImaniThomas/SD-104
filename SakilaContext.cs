using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_5_FilmDataBase
{
    class SakilaContext :DbContext
    {

        public DbSet<Film> Film { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }
    }
}