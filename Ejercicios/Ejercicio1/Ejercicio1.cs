namespace project_OOP.Ejercicios.Ejercicio1
{
    /// <summary>
    /// Clase que representa el primer ejercicio.
    /// Permite al usuario ingresar un número y determina si es positivo, negativo o cero.
    /// También verifica si el número es par o impar.
    /// </summary>
    public class Ejercicio1
    {
        /// <summary>
        /// Ejecuta el ejercicio, solicitando al usuario un número y mostrando información sobre su naturaleza.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("----------------------------------");
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double valor))
            {
                Numero numero = new Numero(valor);

                if (numero.EsPositivo())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número es positivo.");
                    Console.ResetColor();
                }
                else if (numero.EsNegativo())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número es negativo.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número es cero.");
                    Console.ResetColor();
                }

                Console.WriteLine($"¿El número es par? {numero.EsPar()}");
                Console.WriteLine($"¿El número es impar? {numero.EsImpar()}");
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
