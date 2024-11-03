namespace project_OOP.Ejercicios.Ejercicio3
{
    /// <summary>
    /// Clase que representa una persona y evalúa su aptitud para el servicio militar.
    /// </summary>
    internal class Persona
    {
        /// <summary>
        /// Obtiene la edad de la persona.
        /// </summary>
        public int Edad { get; private set; }

        /// <summary>
        /// Obtiene la nacionalidad de la persona.
        /// </summary>
        public string Nacionalidad { get; private set; }

        /// <summary>
        /// Obtiene el género de la persona.
        /// </summary>
        public string Genero { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Persona"/> con la edad, nacionalidad y género especificados.
        /// </summary>
        /// <param name="edad">La edad de la persona.</param>
        /// <param name="nacionalidad">La nacionalidad de la persona.</param>
        /// <param name="genero">El género de la persona.</param>
        public Persona(int edad, string nacionalidad, string genero)
        {
            Edad = edad;
            Nacionalidad = nacionalidad.ToLower();
            Genero = genero.ToLower();
        }

        /// <summary>
        /// Determina si la persona es apta para el servicio militar.
        /// </summary>
        /// <returns><c>true</c> si la persona es apta; de lo contrario, <c>false</c>.</returns>
        public bool EsAptoParaServicioMilitar() =>
            Edad > 18 && Edad < 25 && Nacionalidad == "colombiana" && Genero == "masculino";
    }
}
