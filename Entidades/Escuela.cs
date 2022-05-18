namespace CoreEscuela.Entidades
{
    class Escuela
    {
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
        public Curso[] Cursos { get; set; }

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