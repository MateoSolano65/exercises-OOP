namespace project_OOP.Ejercicios.Ejercicio4
{
    /// <summary>
    /// Clase que representa el cuarto ejercicio.
    /// Permite al usuario ingresar un monto de venta y calcula la comisión correspondiente.
    /// </summary>
    public class Ejercicio4
    {
        /// <summary>
        /// Ejecuta el ejercicio, solicitando al usuario un monto de venta 
        /// y mostrando la comisión calculada basada en ese monto.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("----------------------------------");
            Console.Write("Ingrese el monto de la venta: ");
            string montoInput = Console.ReadLine();
            if (double.TryParse(montoInput, out double monto))
            {
                Venta venta = new Venta(monto);
                double comision = venta.CalcularComision();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"La comisión correspondiente es: {comision}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un monto válido.");
            }
        }
    }
}
