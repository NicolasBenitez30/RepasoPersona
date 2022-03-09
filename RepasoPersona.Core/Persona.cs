using System;

namespace RepasoPersona.Core
{
    public class Persona
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public Double Efectivo { get; private set; }

        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Efectivo = efectivo;
        }

        public void Debitar(Double monto)
        {
            if(monto <= 0)
                throw new Exception("El monto debe ser mayor a cero");
            if(Efectivo < monto)
                throw new Exception("Saldo Insuficiente");

            Efectivo -= monto;
        }

        public void Acreditar(Double monto)
        {
            if(monto <= 0)
                throw new Exception("El monto debe ser mayor a cero");

            Efectivo += monto;
        }

    }
}
