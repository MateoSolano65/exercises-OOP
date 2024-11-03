namespace project_OOP.Ejercicios.Ejercicio1
{
    /// <summary>
    /// Clase que representa un número y proporciona métodos para evaluar sus propiedades.
    /// </summary>
    internal class Numero
    {
        /// <summary>
        /// Obtiene el valor del número.
        /// </summary>
        public double Valor { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Numero"/> con el valor especificado.
        /// </summary>
        /// <param name="valor">El valor del número.</param>
        public Numero(double valor)
        {
            Valor = valor;
        }

        /// <summary>
        /// Determina si el número es positivo.
        /// </summary>
        /// <returns><c>true</c> si el número es positivo; de lo contrario, <c>false</c>.</returns>
        public bool EsPositivo() => Valor > 0;

        /// <summary>
        /// Determina si el número es negativo.
        /// </summary>
        /// <returns><c>true</c> si el número es negativo; de lo contrario, <c>false</c>.</returns>
        public bool EsNegativo() => Valor < 0;

        /// <summary>
        /// Determina si el número es par.
        /// </summary>
        /// <returns><c>true</c> si el número es par; de lo contrario, <c>false</c>.</returns>
        public bool EsPar() => Valor % 2 == 0;

        /// <summary>
        /// Determina si el número es impar.
        /// </summary>
        /// <returns><c>true</c> si el número es impar; de lo contrario, <c>false</c>.</returns>
        public bool EsImpar() => !EsPar();
    }
}
