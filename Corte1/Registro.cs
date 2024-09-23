using System.Collections.Generic;

namespace Corte1.models
{
    internal class Registro
    {
        private List<Persona> personas = new List<Persona>();

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public void MostrarPersonas()
        {
            foreach (Persona persona in personas)
            {
                // Mostrar en la consola
                Console.WriteLine($"{persona.Nombres} {persona.Apellidos} - {persona.Ciudad}");
            }
        }
    }
}
