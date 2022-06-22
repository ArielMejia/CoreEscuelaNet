using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
       // public Curso(string uniqueId, string nombre, TiposJornada jornada) => (UniqueId, Nombre, Jornada) = (uniqueId, nombre, jornada);
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();      
        }
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
    }
}