using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platanito Academy", 2012,
                        TiposEscuela.Primaria, pais:"El Salvador", ciudad:"San Salvador");
            Console.WriteLine(escuela);
        }
    }
}
