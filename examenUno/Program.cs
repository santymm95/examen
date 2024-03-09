namespace examenUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir el sueldo base y la comisión por venta
            double sueldoBase = 1200000;
            double comisionPorVenta = 0.10;

            // Definir las ventas del vendedor
            double[] ventas = new double[] { 500000, 400000, 300000 }; // Ejemplo donde las ventas suman más de 1.000.000

            // Calcular la comisión por las tres ventas
            double comisionTotal = 0;
            foreach (double venta in ventas)
            {
                comisionTotal += venta * comisionPorVenta;
            }
        }
    }
}
