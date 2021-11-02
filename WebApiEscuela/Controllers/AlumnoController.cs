using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEscuela.Models;
using WebApiEscuela.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApiEscuela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AlumnoController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return context.Alumnos.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return context.Alumnos.Find(id);
        }
        [HttpPost]
        public ActionResult Post(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return BadRequest();
            }
            context.Entry(alumno).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
            return alumno;
        }
        [HttpGet("TraerPorMatricula/{nromatricula}")]
        public IEnumerable<Alumno> GetByMatricula(int nromatricula)
        {
            var alumnos = (from a in context.Alumnos
                           where a.NroMatricula == nromatricula
                           select a).ToList();
            return alumnos;
        }
        [HttpGet("TraerPorCiudad/{ciudad}")]
        public IEnumerable<Alumno> GetByCiudad(string ciudad)
        {
            var alumnos = (from a in context.Alumnos
                           where a.Ciudad == ciudad
                           select a).ToList();
            return alumnos;
        }
    }
}
