using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosDeGrado;

using TrabajosDeGrado.mundo.documentos;

namespace TrabajosDeGrado
{
    public partial class EstudianteEstado : Form
    {
        Estudiante logueado;
        EstudiantePrincipal principal;

        public EstudianteEstado(Estudiante e, EstudiantePrincipal ep)
        {
            this.principal = ep;
            logueado = e;
            InitializeComponent();
            llenarTabla();
        }


        private void llenarTabla()
        {
            List<DocumentoPropuesta> propuestas = principal.obtenerDocumentosPropuesta();
            List<DocumentoFinal> finales = principal.obtenerDocumentosFinales();

            if (propuestas == null)
            {
                MessageBox.Show("No se han registrado aun propuestas");
            }
            else
            {
                for (int i = 0; i < propuestas.Count; i++)
                {
                    if (propuestas[i].estado.Equals(IDocumento.EN_ESPERA))
                    {
                        dgvTabla.Rows.Add("Propuesta", propuestas[i].fechaInicio, "En espera", propuestas[i].estado);
                    }
                    else
                    {
                        dgvTabla.Rows.Add("Propuesta", propuestas[i].fechaInicio, propuestas[i].fechaFinal, propuestas[i].estado);
                    }
                }

                for (int i = 0; i < finales.Count; i++)
                {
                    dgvTabla.Rows.Add("Trabajo Final", finales[i].fechaInicio, finales[i].fechaFinal, finales[i].estado);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
