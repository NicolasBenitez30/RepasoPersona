using System;

namespace RepasoPersona.Core
{
    public class Cuenta:Abstraccion
    {
        public int CBU { get;  private set;}
        public Persona Cliente { get; set; }

        public Cuenta(int cbu)
        {
            Cliente = new Persona();
            CBU = cbu;
        }
    }
}