using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString(); 
        string nombre;
        // Aplicando concepto de encapsulamiento para atributo nombre
        // dentro de una propiedad "que accede a la variable"
        public string Nombre {
            get {return "Copia:" + nombre;}
            set {nombre = value.ToUpper();}
        }
        
        // Definiendo atributo y encapsulamiento al mismo tiempo
        public int AñoDeCreación {get;set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }


        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        // Para poder imprimir en consola las propiedades de la clase
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}