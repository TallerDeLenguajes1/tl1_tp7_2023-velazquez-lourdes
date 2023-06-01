namespace Espaciocalculadora
{
    class Calculadora
    {
        private double dato;

        public Calculadora()
        {

        }

        public double Resultado { get => dato;  }

        public void Sumar(double termino)
        {
            dato += termino; 
        }
        public void Resta (double termino)
        {
            dato -= termino; 
        }
        public void Multiplicar (double termino)
        {
            dato *= termino;
        }
        public void Dividir (double termino)
        {
            dato /= termino;
        }
        public void Limpiar()
        {

        }
    }
}