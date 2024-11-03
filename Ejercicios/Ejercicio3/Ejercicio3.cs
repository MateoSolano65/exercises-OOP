namespace project_OOP.Ejercicios.Ejercicio3
{
    /// <summary>
    /// Clase que representa el tercer ejercicio.
    /// Permite al usuario ingresar su edad, nacionalidad y género 
    /// para determinar si es apto para prestar el servicio militar.
    /// </summary>
    public class Ejercicio3
    {
        /// <summary>
        /// Ejecuta el ejercicio, solicitando al usuario su edad, nacionalidad y género, 
        /// y determina si es apto para el servicio militar.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("----------------------------------");
            Console.Write("Ingrese su edad: ");
            string edadInput = Console.ReadLine();
            if (int.TryParse(edadInput, out int edad))
            {
                Console.Write("Ingrese su nacionalidad (colombiana/otro): ");
                string nacionalidad = Console.ReadLine().ToLower();

                // Validación de nacionalidad
                while (nacionalidad != "colombiana" && nacionalidad != "otro")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Nacionalidad inválida. Por favor, ingrese 'colombiana' o 'otro': ");
                    Console.ResetColor();
                    nacionalidad = Console.ReadLine().ToLower();
                }

                Console.Write("Ingrese su género (masculino/femenino): ");
                string genero = Console.ReadLine().ToLower();

                // Validación de género
                while (genero != "masculino" && genero != "femenino")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Género inválido. Por favor, ingrese 'masculino' o 'femenino': ");
                    Console.ResetColor();
                    genero = Console.ReadLine().ToLower();
                }

                Persona persona = new Persona(edad, nacionalidad, genero);
                Console.ForegroundColor = ConsoleColor.Green;
                if (persona.EsAptoParaServicioMilitar())
                    Console.WriteLine("La persona es apta para prestar el servicio militar.");
                else
                    Console.WriteLine("La persona NO es apta para prestar el servicio militar.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese una edad válida.");
            }
        }
    }
}
