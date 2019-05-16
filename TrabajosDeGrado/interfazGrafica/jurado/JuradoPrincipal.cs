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
    public partial class JuradoPrincipal : Form
    {
        Jurado logueado;
        SistemaDeInformacion s;
        public JuradoPrincipal(Jurado j)
        {
            InitializeComponent();
            logueado = j;
            s = SistemaDeInformacion.sistema;
        }
        
        
        private void btnPropuesta_Click(object sender, EventArgs e)
        {
            JuradoConsultarTrabajo jct = new JuradoConsultarTrabajo(logueado,this);
            jct.Show();
        }


        public List<TrabajoDeGrado> listaDeTrabajos()
        {
            List<TrabajoDeGrado> tdg = s.ListaTrabajosDeGrado;

            return tdg;
        }
    }
}
