using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//agregar
using WebApiPersonas.Models;//agregar

namespace WebApiPersonas.Data
{
    public class PeopleDbContext:DbContext
    {
        //Tiene que estar el constructor con parametro definido de esta forma
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options){ }

        public DbSet<Person> People { get; set; }
    }
}
