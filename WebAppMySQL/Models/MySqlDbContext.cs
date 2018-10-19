using System;
using System.Data.Entity;           //Added
using MySql.Data.EntityFramework;   //Added

namespace WebAppMySQL.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))] //Added
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext() : base ("MySqlPeople")
        {

        }

        public DbSet<Person> People { get; set; }
    }
}