﻿using System;
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
            seleccionado = 0;
        }

        private void llenarTabla()
        {
            tdg = ap.listaDeTrabajos();

            for(int i=0; i < tdg.Count; i++)
            {
                if (tdg[i].DocumentosPropuesta.Count > 0 && tdg[i].DocumentosFinales.Count ==0)
                {
                    dgvTabla.Rows.Add(tdg[i].Estudiantes[0].nombre + " "+ tdg[i].Estudiantes[0].apellido, tdg[i].Codigo, tdg[i].Titulo, tdg[i].DocumentosPropuesta.Last<DocumentoPropuesta>().fechaInicio.Date);
                }
            }
        }

        #region acciones botones    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Today);
            tdg[seleccionado].aprobarPropuesta(doc);
            MessageBox.Show("Se ha aprobado la propuesta: "+ tdg[seleccionado].Codigo + ".\nEl documento oficial se encuentra en " + doc.RutaArchivo);
        }

        private void btnCorrecciones_Click(object sender, EventArgs e)
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Today);
            tdg[seleccionado].devolverPropuesta(doc);
            MessageBox.Show("Se ha devuleto para correcciones la propuesta: " + tdg[seleccionado].Codigo + ".\nEl documento oficial se encuentra en " + doc.RutaArchivo);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            DocumentoOficial doc = new DocumentoOficial(DateTime.Today);
            tdg[seleccionado].rechazarPropuesta(doc);
            MessageBox.Show("Se ha rechazado la propuesta: " + tdg[seleccionado].Codigo + ".\nEl documento oficial se encuentra en " + doc.RutaArchivo);
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
