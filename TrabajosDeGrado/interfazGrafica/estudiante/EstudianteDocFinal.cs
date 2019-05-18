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
    public partial class EstudianteDocFinal : Form
    {
        Estudiante logueado;
        EstudiantePrincipal ep;

        public EstudianteDocFinal(Estudiante e, EstudiantePrincipal ep)
        {
            logueado = e;
            InitializeComponent();
            agregarDatosEstudiante();
            this.ep = ep;
        }

        private void agregarDatosEstudiante()
        {
            txtCedula.Text = logueado.Cedula;
            txtCod.Text = logueado.usuario;
            txtNombre.Text = logueado.nombre + " " + logueado.apellido;
            txtSemestre.Text = logueado.Semestre.ToString();
            txtTelefono.Text = logueado.Telefono;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            ofdRuta.ShowDialog();
            txtRuta.Text = ofdRuta.FileName;
            ep.crearDocumentoFinal("", txtRuta.Text, "", DateTime.Today);
            MessageBox.Show("El documento se ha creado con exito, se deberá evaluar antes del día" + DateTime.Today.AddDays(20).Date.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
