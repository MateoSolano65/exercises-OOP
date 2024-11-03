namespace project_OOP.Ejercicios.Ejercicio2
{
    /// <summary>
    /// Clase que representa el segundo ejercicio.
    /// Permite al usuario convertir una temperatura de grados Celsius a Fahrenheit.
    /// </summary>
    public class Ejercicio2
    {
        /// <summary>
        /// Ejecuta el ejercicio, solicitando al usuario una temperatura en grados Celsius 
        /// y mostrando su equivalente en grados Fahrenheit.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("----------------------------------");
            Console.Write("Ingrese la temperatura en grados Centigrados: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double centigrados))
            {
                Temperatura temperatura = new Temperatura(centigrados);
                double fahrenheit = temperatura.ConvertirAFahrenheit();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Por favor ingrese un número.");
                Console.ResetColor();
            }

        }

    }
}
