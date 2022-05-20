using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        // Utilizando constructor para generar el id unico
        public Alumno() => UniqueId = Guid.NewGuid().ToString();       
    }
}