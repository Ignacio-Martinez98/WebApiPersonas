using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApiPersonas.Data;//agregar
using WebApiPersonas.Models;//agregar
using Microsoft.EntityFrameworkCore;

namespace WebApiPersonas.Controllers
{
    //api/people-->navegar
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase

    {
        private readonly PeopleDbContext context;

        public PeopleController(PeopleDbContext context)
        {
            this.context = context;
        }

        //devuelve una lista de todos los elementos
        //IEnumerable es como cuando usabamos List<>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return context.People.ToList();
        }

        //Traer uno por ID
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return context.People.Find(id);
        }

        //Agregar 
        [HttpPost]
        public ActionResult Post(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return Ok();
        }

        //Modificar
        [HttpPut("{id}")]
        public ActionResult Put(int id,Person person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        //Eliminar
        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            Person person = context.People.Find(id);
            if (person == null)
            {
                return NotFound();
            }
            context.People.Remove(person);
            context.SaveChanges();
            return person;
        }

        //api/People/GetByName/Juan
        [HttpGet("{nombre}")]
        public IEnumerable<Person> GetByName(string nombre)
        {
            var people = (from p in context.People
                          where p.Name == nombre
                          select p).ToList();
            return people;
        }
    }
}
