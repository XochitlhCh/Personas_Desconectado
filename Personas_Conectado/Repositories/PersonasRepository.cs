using Personas_Conectado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;

namespace Personas_Conectado.Repositories
{
    public class PersonasRepository
    {
        PersonasContext context = new PersonasContext();


        //READ
        //ienumerable porque muestra todas las personas
        public IEnumerable<Persona> GetAll()
        {
            return context.Persona.OrderBy(x=>x.Nombre);
        }

        public Persona? GetById(int id)//busca por id
        {
            return context.Persona.FirstOrDefault(x=>x.IdPersona == id);
        }

        //CREATE
        public void Insert(Persona p)//objeto de persona,
        {
            if (p !=null)
            {
                //context.Persona.Add(p);
                context.Add(p);
                context.SaveChanges();
            }

        }


        //Update
        public void Update(Persona p)
        {
            var persona = context.Persona.FirstOrDefault(x => x.IdPersona == p.IdPersona);

            if (persona != null)
            {
                persona.Nombre = p.Nombre;
                persona.Genero = p.Genero;
                persona.Edad=p.Edad;
                context.SaveChanges();

            }
        }


        //DELETE
        public void Delete(Persona p)
        {
            if (p != null)
            {
                context.Persona.Remove(p);
                context.SaveChanges();
            }
        }




    }
}
