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
    public partial class AuxRegistrarProrroga : Form
    {
        AuxAdministrativo logueado;
        AuxPrincipal ap;
        List<TrabajoDeGrado> tdg;
        int seleccionado;
        public AuxRegistrarProrroga(AuxAdministrativo a, AuxPrincipal ap)
        {
            logueado = a;
            this.ap = ap;
            tdg = new List<TrabajoDeGrado>();
            InitializeComponent();
            llenarTabla();
            int seleccionado = 0;
        }

        private void llenarTabla()
        {
            tdg = ap.listaDeTrabajos();

            for (int i = 0; i < tdg.Count; i++)
            {
                if (tdg[i].DocumentosProrroga!=null)
                {
                    dgvTabla.Rows.Add(tdg[i].Estudiantes[0], tdg[i].Codigo, tdg[i].Titulo, tdg[i].DocumentosProrroga.fechaFinal);
                }
            }
        }

        private void aprobarProrroga()
        {
            tdg[seleccionado].entregarDocumentoProrroga();
            MessageBox.Show("Se ha aprobado la propuesta. La fecha límite de entrega es: " + tdg[seleccionado].DocumentosPropuesta.Last<DocumentoPropuesta>().fechaFinal);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            aprobarProrroga();
        }


        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
