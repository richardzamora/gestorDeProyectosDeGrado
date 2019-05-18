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
    public partial class EstudiantePrincipal : Form
    {
        EstudiantePropuesta estugui;
        Estudiante logueado;
        SistemaDeInformacion s;
        EstudiantePrincipal ep;
        public EstudiantePrincipal(Estudiante e)
        {
            InitializeComponent();
            logueado = e;
            s = SistemaDeInformacion.sistema;
          
        }

        private void btnPropuesta_Click(object sender, EventArgs e)
        {
            EstudiantePropuesta ep = new EstudiantePropuesta(logueado, this);
            ep.Show();
        }

        public List<DocumentoPropuesta> obtenerDocumentosPropuesta()
        {
            for(int i = 0; i < s.ListaTrabajosDeGrado.Count(); i++)
            {
                for (int j = 0; j < s.ListaTrabajosDeGrado.Count(); j++)
                {
                    if (s.ListaTrabajosDeGrado[i].Estudiantes[j] == logueado)
                    {
                        return s.ListaTrabajosDeGrado[i].DocumentosPropuesta;
                    }
                }   
            }

            return null;
            
        }

        public void crearDocumentoFinal(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            s.crearDocumentoFinal(logueado, titulo, ruta, modalidad, fecha);
        }

        public void crearDocumentoProrroga(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            s.crearDocumentoProrroga(logueado, titulo, ruta, modalidad, fecha);
        }

        public List<DocumentoFinal> obtenerDocumentosFinales()
        {
            for (int i = 0; i < s.ListaTrabajosDeGrado.Count(); i++)
            {
                for (int j = 0; j < s.ListaTrabajosDeGrado.Count(); j++)
                {
                    if (s.ListaTrabajosDeGrado[i].Estudiantes[j] == logueado)
                    {
                        return s.ListaTrabajosDeGrado[i].DocumentosFinales;
                    }
                }
            }

            return null;
        }

        public void crearDocumentoPropuesta(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            s.crearDocumentoPropuesta(logueado,titulo, ruta, modalidad,fecha);            
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            EstudianteEstado ee = new EstudianteEstado(logueado, this);
            ee.Show();
        }

        private void btnProrroga_Click(object sender, EventArgs e)
        {
            EstudianteProrroga ep = new EstudianteProrroga(logueado, this);
            ep.Show();
        }

        private void btnDocFinal_Click(object sender, EventArgs e)
        {
            EstudianteDocFinal edf = new EstudianteDocFinal(logueado, this);
            edf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void propuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estugui = new EstudiantePropuesta(logueado, ep);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
