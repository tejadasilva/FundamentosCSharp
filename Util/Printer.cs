using static System.Console;

namespace CoreEscuela.Util
{
    // Clase estatica no permite crear nuevas instancias, funcionara como un objeto
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            WriteLine("".PadLeft(tamaño, '='));
        }

        public static void WriteTitle(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }        
    }
}