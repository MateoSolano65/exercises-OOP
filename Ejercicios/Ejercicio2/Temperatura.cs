namespace project_OOP.Ejercicios.Ejercicio2
{
    /// <summary>
    /// Clase que representa una temperatura y proporciona métodos para convertirla entre escalas.
    /// </summary>
    internal class Temperatura
    {
        /// <summary>
        /// Obtiene la temperatura en grados Celsius.
        /// </summary>
        public double GradosCentigrados { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Temperatura"/> con la temperatura en grados Celsius.
        /// </summary>
        /// <param name="gradosCentigrados">La temperatura en grados Celsius.</param>
        public Temperatura(double gradosCentigrados)
        {
            GradosCentigrados = gradosCentigrados;
        }

        /// <summary>
        /// Convierte la temperatura de grados Celsius a grados Fahrenheit.
        /// </summary>
        /// <returns>La temperatura convertida en grados Fahrenheit.</returns>
        public double ConvertirAFahrenheit() => (GradosCentigrados * 9 / 5) + 32;
    }
}
