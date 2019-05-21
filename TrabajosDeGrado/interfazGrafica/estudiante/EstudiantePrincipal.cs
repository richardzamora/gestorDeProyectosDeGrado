using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TrabajosDeGrado.mundo.documentos;

namespace TrabajosDeGrado
{
    public partial class EstudiantePrincipal : Form
    {
        Estudiante logueado;
        SistemaDeInformacion sistema;

        public EstudiantePrincipal(Estudiante e)
        {
            InitializeComponent();
            logueado = e;
            sistema = SistemaDeInformacion.sistema;
        }

        private void btnPropuesta_Click(object sender, EventArgs e)
        {
            EstudiantePropuesta ep = new EstudiantePropuesta(logueado, this);
            ep.Show();
        }

        private void btnProrroga_Click(object sender, EventArgs e)
        {
            List<DocumentoPropuesta> propuestas = obtenerDocumentosPropuesta();

            if(propuestas == null)
            {
                MessageBox.Show("Aun no se han registrado propuestas");
            }
            else
            {
                if (!propuestas[propuestas.Count - 1].estado.Equals(IDocumento.APROBADO))
                {
                    MessageBox.Show("La propuesta enviada aun no ha sido aprobada.");
                }
                else
                {
                    EstudianteProrroga ep = new EstudianteProrroga(logueado, this);
                    ep.Show();
                }
            }  
        }

        private void btnDocFinal_Click(object sender, EventArgs e)
        {
            List<DocumentoPropuesta> propuestas = obtenerDocumentosPropuesta();

            if (propuestas == null)
            {
                MessageBox.Show("Aun no se han registrado propuestas");
            }
            else
            {
                if (!propuestas[propuestas.Count - 1].estado.Equals(IDocumento.APROBADO))
                {
                    MessageBox.Show("La propuesta enviada aun no ha sido aprobada.");
                }
                else
                {
                    EstudianteDocFinal edf = new EstudianteDocFinal(logueado, this);
                    edf.Show();
                }
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            EstudianteEstado ee = new EstudianteEstado(logueado, this);
            ee.Show();
        }

        public List<DocumentoPropuesta> obtenerDocumentosPropuesta()
        {
            for(int i = 0; i < sistema.ListaTrabajosDeGrado.Count(); i++)
            {
                List<Estudiante> estudiantes = sistema.ListaTrabajosDeGrado[i].Estudiantes;
                for (int j = 0; j < estudiantes.Count; j++)
                {
                    if (sistema.ListaTrabajosDeGrado[i].Estudiantes[j] == logueado)
                    {
                        return sistema.ListaTrabajosDeGrado[i].DocumentosPropuesta;
                    }
                }   
            }

            return null; 
        }

        public List<DocumentoFinal> obtenerDocumentosFinales()
        {
            for (int i = 0; i < sistema.ListaTrabajosDeGrado.Count(); i++)
            {
                List<Estudiante> estudiantes = sistema.ListaTrabajosDeGrado[i].Estudiantes;
                for (int j = 0; j < estudiantes.Count; j++)
                {
                    if (sistema.ListaTrabajosDeGrado[i].Estudiantes[j] == logueado)
                    {
                        return sistema.ListaTrabajosDeGrado[i].DocumentosFinales;
                    }
                }
            }

            return null;
        }

        public void crearDocumentoFinal(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            sistema.crearDocumentoFinal(logueado, titulo, ruta, modalidad, fecha);
        }

        public void crearDocumentoProrroga(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            sistema.crearDocumentoProrroga(logueado, titulo, ruta, modalidad, fecha);
        }

        public void crearDocumentoPropuesta(String titulo, String ruta, String modalidad, DateTime fecha)
        {
            sistema.crearDocumentoPropuesta(logueado,titulo, ruta, modalidad,fecha);            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
