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
                if(propuestas[i].Respuesta == null)
                {
                    dgvTabla.Rows.Add("Propuesta", propuestas[i].Fecha,"Sin aprobar");
                }
                else
                {
                    dgvTabla.Rows.Add("Propuesta", propuestas[i].Fecha, propuestas[i].Respuesta.RutaArchivo);
                }
                    
            }

            for (int i = 0; i < finales.Count; i++)
            {
                if (finales[i].ArchivoEvaluacion == null)
                {
                    dgvTabla.Rows.Add("Trabajo Final", finales[i].FechaEntrega, "Sin evaluar");
                }
                else
                {
                    dgvTabla.Rows.Add("Trabajo Final", finales[i].FechaEntrega, finales[i].ArchivoEvaluacion.RutaArchivo);
                }
                
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
