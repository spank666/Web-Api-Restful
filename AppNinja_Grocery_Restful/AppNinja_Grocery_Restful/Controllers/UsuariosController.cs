using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AppNinja_Grocery_Restful.Controllers
{
    public class Person

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Twitter { get; set; }

    }
    public class UsuariosController : ApiController
    {
        // GET api/Usuarios
        public List<Person> GetPerson()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "Julio", LastName = "Avellaneda", Twitter = "@julitogtu" });
            persons.Add(new Person { Name = "Juan", LastName = "Ruiz", Twitter = "@juankruiz" });
            persons.Add(new Person { Name = "Roberto", LastName = "Alvarado", Twitter = "@ralvaradot" });
            persons.Add(new Person { Name = "Nicolas", LastName = "Herrera", Twitter = "@nicolocodev" });
            persons.Add(new Person { Name = "Jorge", LastName = "Ramirez", Twitter = "@jramirezdev" });
            return persons;
        }
    }
}