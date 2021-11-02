using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEscuela.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiEscuela.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

    }
}

