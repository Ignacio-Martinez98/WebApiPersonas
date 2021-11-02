using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWMedicos.Models;


namespace SWMedicos.Data
{
    public class DBHospitalContext:DbContext
    {
        public DBHospitalContext(DbContextOptions<DBHospitalContext> options) : base(options) { }
        public DbSet<Medico> Medicos { get; set; }
    }
}
