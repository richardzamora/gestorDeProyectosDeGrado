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
    public partial class AuxAsignarJurados : Form
    {
        AuxAdministrativo logueado;
        AuxPrincipal ap;
        List<TrabajoDeGrado> tdg;
        List<Jurado> jurados;
        int seleccionado;
        int seleccionadoJurado;

        public AuxAsignarJurados(AuxAdministrativo a, AuxPrincipal ap)
        {
            logueado = a;
            this.ap = ap;
            tdg = new List<TrabajoDeGrado>();
            jurados = new List<Jurado>();
            InitializeComponent();
            llenarTablaJurados();
            llenarTabla();
            int seleccionado = 0;
            int seleccionadoJurado = 0;
        }

        private void llenarTabla()
        {
            tdg = ap.listaDeTrabajos();

            for (int i = 0; i < tdg.Count; i++)
            {
                if (tdg[i].DocumentosFinales.Count>0)
                {
                    dgvTabla.Rows.Add(tdg[i].Estudiantes[0], tdg[i].Codigo, tdg[i].Titulo, tdg[i].DocumentosProrroga.fechaFinal);
                }
            }
        }

        private void llenarTablaJurados()
        {
            jurados = ap.listaJurados();

            for (int i = 0; i < jurados.Count; i++)
            {
                if (jurados[i].Estado.Equals(Jurado.LIBRE))
                {
                    dgvJurados.Rows.Add(jurados[i].nombre, jurados[i].apellido, jurados[i].NumeroTajetaProfecional, jurados[i].usuario);
                }
            }
        }

        public void asignarJurados()
        {
            tdg[seleccionado].JuradosAsignados.Add(jurados[seleccionadoJurado]);
            MessageBox.Show("Se ha asignado el jurado "+ jurados[seleccionadoJurado].nombre + jurados[seleccionadoJurado].apellido + " al trabajo de grado satisfactoriamente");
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            asignarJurados();
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        private void dgvJurados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoJurado = e.RowIndex;
        }

        private void AuxAsignarJurados_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
