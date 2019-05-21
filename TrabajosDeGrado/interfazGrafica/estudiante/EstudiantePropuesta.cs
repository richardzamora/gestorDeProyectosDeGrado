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
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals(""))
            {
                MessageBox.Show("La propuesta necesita un título.\nPor favor complete el campo Título de propuesta y vuelva a intentarlo.");
            }
            else
            {
                if (comboBoxModalidad.Text.Equals(""))
                {
                    MessageBox.Show("Es necesario elegir una modalidad para su propuesta.");
                }
                else
                {
                    ep.crearDocumentoPropuesta(txtTitulo.Text, txtRuta.Text, comboBoxModalidad.Text, DateTime.Now);
                    MessageBox.Show("El documento se ha creado con exito, se deberá aprobar antes del día: " + DateTime.Today.Date.AddDays(20).Date.ToString());
                }
            }
        }

        #region Métodos no usados
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void EstudiantePropuesta_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
