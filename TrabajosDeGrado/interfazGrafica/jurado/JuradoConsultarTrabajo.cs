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
    public partial class JuradoConsultarTrabajo : Form
    {
        Jurado logueado;
        JuradoPrincipal ap;
        List<TrabajoDeGrado> tdg;
        int seleccionado;
        
        public JuradoConsultarTrabajo(Jurado a, JuradoPrincipal ap)
        {
            logueado = a;
            this.ap = ap;
            tdg = new List<TrabajoDeGrado>();
            InitializeComponent();
            llenarTabla();
            seleccionado = 0;
        }


        private void llenarTabla()
        {
            tdg = ap.listaDeTrabajos();

            for (int i = 0; i < tdg.Count; i++)
            {
                for(int j = 0; j < tdg[i].JuradosAsignados.Count; j++)
                {
                    if (tdg[i].JuradosAsignados[j].Equals(logueado)) 
                    {
                        dgvTabla.Rows.Add(tdg[i].Estudiantes[0].nombre+" "+ tdg[i].Estudiantes[0].apellido, tdg[i].Codigo, tdg[i].Titulo, "En proceso de construcción"/*+tdg[i].DocumentosFinales.Last<DocumentoFinal>().fechaFinal*/);
                    }
                }
                
            }
        }

        
        private void aprobarTrabajoFinal()
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Now);
            if(comboBoxMencion.Text.Equals(""))
            {
                MessageBox.Show("Es necesario registrar una mención");
            }
            else
            {
                tdg[seleccionado].aprobarDocumentoFinal(comboBoxMencion.Text, doc);
                MessageBox.Show("Se ha aprobado el trabajo. El documento oficial se encuentra en " + doc.RutaArchivo);
            }
        }

        private void devolverParaCorrecciones()
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Now);
            if (comboBoxMencion.Text.Equals(""))
            {
                MessageBox.Show("Es necesario registrar una mención");
            }
            else
            {
                tdg[seleccionado].aprobarDocumentoFinal(comboBoxMencion.Text, doc);
                MessageBox.Show("Se ha aprobado el trabajo. El documento oficial se encuentra en " + doc.RutaArchivo);
            }
        }

        private void btnCalificar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxMencion.Text.Equals("Devolver para correcciones"))
            {
                devolverParaCorrecciones();
            }
            else
            {
                aprobarTrabajoFinal();
            }
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
