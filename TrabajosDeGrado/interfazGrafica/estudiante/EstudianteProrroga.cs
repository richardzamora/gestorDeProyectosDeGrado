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
    public partial class EstudianteProrroga : Form
    {
        Estudiante logueado;
        EstudiantePrincipal ep;

        public EstudianteProrroga(Estudiante e, EstudiantePrincipal ep)
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
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ep.crearDocumentoProrroga("", txtRuta.Text, "", DateTime.Today);
            MessageBox.Show("El documento se ha enviado con éxito, se deberá evaluar antes del día" + DateTime.Today.AddDays(20).Date.ToString());
        }

        #region Métodos no usados
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
