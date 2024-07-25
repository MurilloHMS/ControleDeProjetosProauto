using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetosProauto.Setup.DataBase
{
    internal class ControleContext : DbContext
    {
        private string _connectionString;
        public ControleContext()
        {
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }
            string PathArquivo = Path.Combine(dbDiretorio, "System.db");

            //_connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={PathArquivo};Initial Catalog=ControleDeValidades;Integrated Security=True;Connect Timeout=30";
            _connectionString = $"Data Source = {PathArquivo};Cache=Shared";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();

    }
}
