using System.Text;

namespace Ejercicio1.Entidades
{
    public class Cono
    {
        private readonly int _radio;
        private readonly int _altura;

        private double generatriz;

        public Cono(int radio, int altura)
        {
            if (radio < 0 || altura < 0)
            {
                throw new ArgumentException("Los valores deben ser ayores a cero.");  
            }
            _radio = radio;
            _altura = altura;
        }
        private double GetGeneratriz()
        {
            return Math.Sqrt(Math.Pow(_altura, 2) + Math.Pow(_radio, 2));
        }
        public double GetArea()
        {
            double aBase = Math.PI * Math.Pow(_radio, 2);
            double lateral = Math.PI * _radio + GetGeneratriz();
            double area = aBase + lateral;
            return area;
        }

        public double GetVolumen()
        {
            return (Math.PI * Math.Pow(_radio, 2) * _altura) / 3;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cono de: ");
            datos.AppendLine($"Radio: {_radio}");
            datos.AppendLine($"ALtura: {_altura}");
            datos.AppendLine($"Area: {GetArea()}");
            datos.AppendLine($"Volumen: {GetVolumen()}");
            datos.AppendLine($"Generatriz: {GetGeneratriz()}");

            return datos.ToString();
        }
    }
}