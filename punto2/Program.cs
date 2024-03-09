namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Velocidades de los trenes
            double velocidadTren1 = 80; // km/h
            double velocidadTren2 = 100; // km/h

            // Distancia recorrida por el primer tren cuando el segundo tren comienza su viaje
            double distanciaRecorrida = velocidadTren1; // km

            // Tiempo que le toma al segundo tren alcanzar la distancia recorrida por el primer tren
            double tiempo = distanciaRecorrida / velocidadTren2; // horas


        }
    }
}
