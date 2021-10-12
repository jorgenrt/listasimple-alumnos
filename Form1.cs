using System;
using System.Windows.Forms;

namespace Registro_alumnos
{
    public partial class Form1 : Form
    {
        ListaAlumno miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new ListaAlumno();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            int numero = 0;
            string matricula = txtMatricula.Text;
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmterno.Text;
            string especialidad = txtEspecialidad.Text;
            int semestre  = int.Parse(txtSemestre.Text);
            Nodo n = new Nodo(numero, matricula, nombre, aPaterno, aMaterno, especialidad, semestre);

            miLista.Agregar(n);
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApaterno.Clear();
            txtAmterno.Clear();
            txtEspecialidad.Clear();
            txtSemestre.Clear();
            miLista.Mostrar(lstDatos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtMatricula.Text);
            Nodo b = new Nodo();
            if (miLista.Buscar(numero, b))
            {
                txtNombre.Text = b.Nombre;
                txtApaterno.Text = b.Apaterno;
                txtAmterno.Text = b.Amaterno;
                txtEspecialidad.Text = b.Especialidad;
                
            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtMatricula.Text);
            miLista.Eliminar(numero);
            txtMatricula.Clear();
            txtMatricula.Focus();
            miLista.Mostrar(lstDatos);
        }
    }

}
