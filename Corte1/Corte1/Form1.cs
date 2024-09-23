using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro = new Registro();
        private Operacion operacion = new Operacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva persona con los datos ingresados
                Persona persona = new Persona
                {
                    Nombres = tbNombre.Text,
                    Apellidos = tbApellido.Text,
                    FechaNacimiento = dtpNacim.Value,
                    Ciudad = cbCiudad.SelectedItem.ToString()
                };

                // Agregar la persona al registro
                registro.AgregarPersona(persona);

                // Mostrar en la listbox
                lbRegistro.Items.Add($"{persona.Nombres} {persona.Apellidos} - {persona.Ciudad}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lbRegistro.SelectedItem != null)
            {
                // Obtener la persona seleccionada
                int index = lbRegistro.SelectedIndex;
                Persona persona = registro.ObtenerPersonas()[index] as Persona;

                // Calcular la edad y determinar si es mayor o menor de edad
                int edad = operacion.CalcularEdad(persona.FechaNacimiento);
                string mayorOMenor = operacion.EsMayorEdad(edad);

                // Mostrar la edad y si es mayor o menor de edad
                MessageBox.Show($"{persona.Nombres} {persona.Apellidos} tiene {edad} años y es {mayorOMenor}.");
            }
            else
            {
                MessageBox.Show("Seleccione una persona de la lista.");
            }
        }
    }
}
        
    


