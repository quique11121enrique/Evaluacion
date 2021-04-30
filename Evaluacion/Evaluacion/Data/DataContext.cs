using Microsoft.EntityFrameworkCore;
using System;
using Evaluacion.Data.Entities;


namespace Evaluacion.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
