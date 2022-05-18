using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        // Utilizando constructor para generar el id unico
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}