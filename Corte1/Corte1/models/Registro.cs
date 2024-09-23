using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas;

        public Registro()
        {
            personas = new Persona[30];
        }

        public void AgregarPersona(Persona persona)
        {
            for (int i = 0; i < personas.Length; i++)
            {
                if (personas[i] == null)
                {
                    personas[i] = persona;
                    break;
                }
            }
        }
        public void MostrarPersonas()
        {
            foreach (Persona persona in personas)
            {
                if (persona != null)
                {
                    Console.WriteLine($"Nombres: {persona.Nombres}, Apellidos: {persona.Apellidos}, Fecha Nacimiento: {persona.FechaNacimiento}, Ciudad: {persona.Ciudad}");
                }
            }

        }
    }
}
