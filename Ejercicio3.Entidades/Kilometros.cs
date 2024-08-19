namespace Ejercicio3.Entidades
{
    public class Kilometros
    {
        private float _distancia;
        
        public float GetDistancia() => _distancia;

        private float equivalencia = 1.6093F;

        public float GetEquivalenciaM() => equivalencia;

        public Kilometros(float distancia=100)
        {
            _distancia= distancia;
        }

        public static implicit operator float(Kilometros k)
        {
            return k._distancia;
        }

       

        public static bool operator==(Kilometros k, Millas m)
        {
            return k.GetDistancia() == m.GetDistancia() * 1.6093;
        }

        public static bool operator !=(Kilometros k, Millas m)
        {
            return !(k == m);
        }

        //public static bool operator +(Kilometros k , Millas m)
        //{
        //    k.GetDistancia + (m.GetDistancia() * 1.6092):
        //}





    }
}