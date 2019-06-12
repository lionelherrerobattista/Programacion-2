using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades_Ejercicio_61;

namespace Ejercicio_61
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;

            PersonaDAO personaDAO;
            Persona auxPersona;

            personaDAO = new PersonaDAO();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;

            auxPersona = new Persona(nombre, apellido);

            personaDAO.Guardar(auxPersona);
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            Persona personaSeleccionada;

            personaSeleccionada = (Persona)lstPersonas.SelectedItem;

            txtNombre.Text = personaSeleccionada.Nombre;
            txtApellido.Text = personaSeleccionada.Apellido;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            PersonaDAO personaDAO;
            List<Persona> listaPersonas;

            personaDAO = new PersonaDAO();

            lstPersonas.Items.Clear();

            listaPersonas = personaDAO.Leer();

            foreach (Persona persona in listaPersonas)
            {
                
                lstPersonas.Items.Add(persona);
            }

            lstPersonas.DisplayMember = "Id";

            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;

            PersonaDAO personaDAO;

            personaDAO = new PersonaDAO();

            id = ((Persona)lstPersonas.SelectedItem).Id;

            personaDAO.Borrar(id);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int id;

            PersonaDAO personaDAO = new PersonaDAO();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            id = ((Persona)lstPersonas.SelectedItem).Id;

            personaDAO.Modificar(id, nombre, apellido);
        }
    }
}
