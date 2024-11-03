using project_OOP.Ejercicios.Ejercicio1;
using project_OOP.Ejercicios.Ejercicio2;
using project_OOP.Ejercicios.Ejercicio3;
using project_OOP.Ejercicios.Ejercicio4;

namespace project_OOP;

/// <summary>
/// Clase principal que contiene el método de entrada del programa.
/// Permite al usuario seleccionar entre varios ejercicios relacionados con operaciones básicas.
/// </summary>
class Program
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// Presenta un menú al usuario y ejecuta la opción seleccionada.
    /// </summary>
    /// <param name="args">Argumentos de línea de comandos (no se utilizan en este programa).</param>
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Determinar si un número es positivo o negativo");
            Console.WriteLine("2. Convertir temperatura de Celsius a Fahrenheit");
            Console.WriteLine("3. Verificar aptitud para el servicio militar");
            Console.WriteLine("4. Calcular comisión de ventas");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    new Ejercicio1().Execute();
                    break;
                case 2:
                    new Ejercicio2().Execute();
                    break;
                case 3:
                    new Ejercicio3().Execute();
                    break;
                case 4:
                    new Ejercicio4().Execute();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }
}