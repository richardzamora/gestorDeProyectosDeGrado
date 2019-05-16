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
    public partial class AuxRegistrarPropuesta : Form
    {
        AuxAdministrativo logueado;
        AuxPrincipal ap;
        List<TrabajoDeGrado> tdg;
        int seleccionado;
        public AuxRegistrarPropuesta(AuxAdministrativo a, AuxPrincipal ap)
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

            for(int i=0; i < tdg.Count; i++)
            {
                if (tdg[i].DocumentosPropuesta.Count > 0 && tdg[i].DocumentosFinales.Count ==0)
                {
                    dgvTabla.Rows.Add(tdg[i].Estudiantes[0], tdg[i].Codigo, tdg[i].Titulo, tdg[i].DocumentosPropuesta.Last<DocumentoPropuesta>().FechaLimiteEntregaResultado);
                }
            }
        }

        private void aprobarPropuesta()
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Today);
            tdg[seleccionado].aprobarPropuesta(doc);
            MessageBox.Show("Se ha aprobado la propuesta. El documento oficial se encuentra en " + doc.RutaArchivo);
        }

        #region acciones botones    
        private void btnSubir_Click(object sender, EventArgs e)
        {
            aprobarPropuesta();
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        #endregion
    }
}
