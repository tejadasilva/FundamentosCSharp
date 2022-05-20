            /*
            // Agregar por rangos
            escuela.Cursos.AddRange(otraColeccion);
            // Agregando elemento
            Curso tmp =  new Curso{Nombre = "101-Vacacional", Jornada = TiposJornada.Noche};
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            // Obteniendo hash del objeto Ttmp
            WriteLine("Curso.Hash " + tmp.GetHashCode());
            // Eliminando elemento, manera 1
            // escuela.Cursos.Remove(tmp);

            // Eliminando elemento, manera 2
            escuela.Cursos.RemoveAll(delegate (Curso cur)
                                    {
                                        return cur.Nombre == "301";
                                    });
            // Eliminando elemento, manera 3
            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "301");
            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);
            */


            // Ejemplo de arreglo
            // escuela.Cursos = new Curso[] {
            //     new Curso(){Nombre = "101"},
            //     new Curso(){Nombre = "201"},
            //     new Curso(){Nombre = "301"},
            // };            


        // Para lo siguiente es necesario el uso de arreglos
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

        // Constructor
        // El constructor es un metodo
        // Existen muchas maneras de crear el constructor 
        // Manera 1
        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     AñoDeCreación = año;
        // }
        // Manera 2 (igualación por tuplas)
        // public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);
        // Manera 3, para este ejemplo pais, ciudad es opcional        