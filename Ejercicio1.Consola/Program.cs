using Ejercicio1.Entidades;
using MiDLL.dll;

namespace Ejercicio1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radio = ConsoleExtensions.ReadInt("Ingresar el radio la base del cono:");
            int altura = ConsoleExtensions.ReadInt("ingresar la altura del cono:");
            Cono cono = new Cono(radio, altura);
            Console.WriteLine($"{cono.MostrarDatos()}");
        }
    }
}