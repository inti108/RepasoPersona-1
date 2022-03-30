using System;

namespace RepasoPersona.Core
{
    public class Cuenta
    {
        public double Efectivo {get ; private set; }
        public double Monto {get ; private set; }
        public void Debitar(double Monto)
        {
            if (Monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (Monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Efectivo -= Monto;
        }
        public void Acreditar(double Monto)
        {
            if (Monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Efectivo += Monto;
        }
    }
}