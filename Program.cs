using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platanito Academy", 2012,
                        TiposEscuela.Primaria, pais: "El Salvador", ciudad: "San Salvador");

            escuela.Cursos = new Curso[] {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"},
            };

            ImprimirCursosEscuela(escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (escuela != null && escuela.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }

        // Manera 1, while
        // private static void ImprimirCursosWhile(Curso[] arreglosCursos)
        // {
        //     int contador = 0;
        //     while (contador < arreglosCursos.Length)
        //     {
        //         System.Console.WriteLine($"Nombre {arreglosCursos[contador].Nombre}, Id {arreglosCursos[contador].UniqueId}");
        //         contador ++;
        //     }
        // }

        // Manera 2, Do While
        // private static void ImprimirCursosDoWhile(Curso[] arreglosCursos)
        // {
        //     int contador = 0;
        //     do
        //     {
        //         System.Console.WriteLine($"Nombre {arreglosCursos[contador].Nombre}, Id {arreglosCursos[contador].UniqueId}");
        //         contador ++;
        //     }while (contador < arreglosCursos.Length);
        // }
        // Manera 3, For
        // private static void ImprimirCursosFor(Curso[] arreglosCursos)
        // {
        //     for (int i = 0; i < arreglosCursos.Length; i++)
        //     {
        //         Console.WriteLine($"Nombre {arreglosCursos[i].Nombre}, Id {arreglosCursos[i].UniqueId}");
        //     }
        // }
        // Manera 4, For Each
        // private static void ImprimirCursosForEach(Curso[] arreglosCursos)
        // {
        //     foreach (var curso in arreglosCursos)
        //     {
        //         Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
        //     }
        // }
    }
}
