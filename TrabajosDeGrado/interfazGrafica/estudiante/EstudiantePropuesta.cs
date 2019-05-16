using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosDeGrado
{
    public partial class EstudiantePropuesta : Form
    {
        Estudiante logueado;
        EstudiantePrincipal ep;
        public EstudiantePropuesta(Estudiante e, EstudiantePrincipal ep)
        {
            logueado = e;
            InitializeComponent();
            agregarDatosEstudiante();
            this.ep = ep;
        }

        private void agregarDatosEstudiante()
        {
            txtCedula.Text = logueado.Cedula;
            txtcod.Text = logueado.usuario;
            txtNombre.Text = logueado.nombre + " " + logueado.apellido;
            txtSemestre.Text = logueado.Semestre.ToString();
            txtTelefono.Text = logueado.Telefono;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            ofdRuta.ShowDialog();
            txtRuta.Text = ofdRuta.FileName;
            ep.crearDocumentoPropuesta(txtTitulo.Text,txtRuta.Text,txtModalidad.Text,DateTime.Today);
            MessageBox.Show("El documento se ha creado con exito, se deberá aprobar antes del día" + DateTime.Today.AddDays(20).Date.ToString());
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
