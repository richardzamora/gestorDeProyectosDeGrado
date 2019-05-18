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

namespace TrabajosDeGrado
{
    public partial class EstudianteEstado : Form
    {
        Estudiante logueado;
        EstudiantePrincipal ep;

        public EstudianteEstado(Estudiante e, EstudiantePrincipal ep)
        {
            this.ep = ep;
            logueado = e;
            InitializeComponent();
            llenarTabla();
        }


        private void llenarTabla()
        {
            List<DocumentoPropuesta> propuestas = ep.obtenerDocumentosPropuesta();
            List<DocumentoFinal> finales = ep.obtenerDocumentosFinales();

            for (int i = 0; i < propuestas.Count; i++)
            {
                if(propuestas[i].respuesta == null)
                {
                    dgvTabla.Rows.Add("Propuesta", propuestas[i].fechaInicio,"Sin aprobar");
                }
                else
                {
                    dgvTabla.Rows.Add("Propuesta", propuestas[i].fechaInicio, propuestas[i].respuesta.RutaArchivo);
                }
                    
            }

            for (int i = 0; i < finales.Count; i++)
            {
                if (finales[i].archivoEvaluacion == null)
                {
                    dgvTabla.Rows.Add("Trabajo Final", finales[i].fechaFinal, "Sin evaluar");
                }
                else
                {
                    dgvTabla.Rows.Add("Trabajo Final", finales[i].fechaFinal, finales[i].archivoEvaluacion.RutaArchivo);
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
