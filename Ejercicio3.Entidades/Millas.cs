using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Millas
    {
        private float _distancia;

        public float GetDistancia() => _distancia;

        public Millas(float distancia = 100)
        {
            _distancia = distancia;
        }

        public static implicit operator float(Millas m)
        {
            return m._distancia;
        }

        public static bool operator ==(Millas m, Kilometros k)
        {
            return m.GetDistancia() == k.GetDistancia() * 0.621371;
        }
        public static bool operator != (Millas millas, Kilometros k)
        {
            return !(millas == k);
        }




    }
}
