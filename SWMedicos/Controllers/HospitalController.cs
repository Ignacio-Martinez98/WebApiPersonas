using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWMedicos.Data;
using SWMedicos.Models;

namespace SWMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DBHospitalContext context;
        public HospitalController(DBHospitalContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Medico> Get()
        {
            return context.Medicos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Medico> Get(int id)
        {
            return context.Medicos.Find(id);
        }
        [HttpPost]
        public ActionResult Post(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, Medico medico)
        {
            if (id != medico.Id)
            {
                return BadRequest();
            }
            context.Entry(medico).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Medico> Delete(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            context.Medicos.Remove(medico);
            context.SaveChanges();
            return medico;
        }
        [HttpGet("TraerEspecialidad/{especialidad}")]
        public IEnumerable<Medico> GetByEspecialidad(string especialidad)
        {
            var medicos = (from m in context.Medicos
                          where m.Especialidad == especialidad
                          select m).ToList();
            return medicos;
        }
    }
}
