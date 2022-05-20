using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        // Tipo de dato void es vacio
        public void Inicializar()
        {
            Escuela = new Escuela("Platanito Academy", 2012,
            TiposEscuela.Primaria, pais: "El Salvador", ciudad: "San Salvador");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matemáticas"},
                    new Asignatura{Nombre="Eduación Física"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            // Utilizando arreglos, "producto cartesiano"
            string[] nombre1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] apellido1 = {"Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};
            string[] nombre2 = {"Freddy", "Anabel", "Rick", "Morty", "Diomedes", "Nicomedes", "Teodoro"};

            // Utilizando Linq
            var listaAlumnos = 
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Alumno{ Nombre=$"{n1} {n2} {a1}" };

            // Tomando alumnos de manera aleatoria, luego convertir a lista
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();

        }

        private void CargarCursos()
        {
            // Ejemplo de colección
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde},
            };

            Random rnd =  new Random();
            
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos =  GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}