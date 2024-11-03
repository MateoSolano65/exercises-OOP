using System;

namespace project_OOP.Ejercicios.Ejercicio4
{
    /// <summary>
    /// Clase que representa una venta y proporciona métodos para calcular comisiones.
    /// </summary>
    internal class Venta
    {
        /// <summary>
        /// Obtiene el monto de la venta.
        /// </summary>
        public double Monto { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Venta"/> con el monto especificado.
        /// </summary>
        /// <param name="monto">El monto de la venta.</param>
        public Venta(double monto)
        {
            Monto = monto;
        }

        /// <summary>
        /// Calcula la comisión basada en el monto de la venta.
        /// Si el monto es menor a 1000, la comisión es del 3%; de lo contrario, es del 5%.
        /// </summary>
        /// <returns>El monto de la comisión calculada.</returns>
        public double CalcularComision() => Monto < 1000 ? Monto * 0.03 : Monto * 0.05;
    }
}
