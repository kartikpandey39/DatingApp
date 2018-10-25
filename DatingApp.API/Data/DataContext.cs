using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        // convention is to pluralize the class name as it will be a table in DB
        public DbSet<Value> Values {get;set;}
    }
}