﻿using ControleDeProjetosProauto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeProjetosProauto.Setup.DataBase
{
    internal class ControleContext : DbContext
    {
        private string _connectionString;

        public DbSet<Projetos> projetos { get; set; }
        public ControleContext()
        {
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }
            string PathArquivo = Path.Combine(dbDiretorio, "System.db");

            _connectionString = $"Data Source = {PathArquivo};Cache=Shared";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();

    }
}
