using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Console
{
    /// <summary>
    /// Производный класс от DbContext, определяет контекст, используемый для взаимодействия с бд
    /// </summary>
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!; // хранит набор объектов, осуществляет связь с таблицей User
        public ApplicationContext() => Database.EnsureCreated(); // проверка на наличие созданной бд

        /// <summary>
        /// Подключение к бд
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = efcore.db");
        }
    }
}
