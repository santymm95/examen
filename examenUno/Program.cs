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

            // Calcular el total recibido en el mes (sueldo base + comisiones)
            double totalMes = sueldoBase + comisionTotal;

            // Encontrar la venta que generó la mayor comisión
            double mayorComision = 0;
            foreach (double venta in ventas)
            {
                double comisionVenta = venta * comisionPorVenta;
                if (comisionVenta > mayorComision)
                {
                    mayorComision = comisionVenta;
                }
            }

            // Calcular el promedio de las comisiones por venta
            double promedioComisiones = comisionTotal / ventas.Length;

            // Verificar si el vendedor superó el objetivo del mes
            double totalVentas = 0;
            foreach (double venta in ventas)
            {
                totalVentas += venta;
            }
            bool superaObjetivo = totalVentas >= 1000000;

            // Si supera el objetivo del mes, sumar el beneficio extra
            if (superaObjetivo)
            {
                totalMes += 100000;
                Console.WriteLine("¡Felicidades! Has superado el objetivo del mes y ganaste un beneficio extra de $100.000");
            }
            else
            {
                Console.WriteLine("No has superado el objetivo del mes.");
            }

                Console.WriteLine($"Comisiones por las tres ventas: ${comisionTotal}");
                Console.WriteLine($"Total recibido en el mes: ${totalMes}");
                Console.WriteLine($"Venta que generó la mayor comisión: ${mayorComision}");
                Console.WriteLine($"Promedio de las comisiones por venta: ${promedioComisiones}");

                Console.ReadLine();
    }
}

        }
    
