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
    public partial class AuxPrincipal : Form
    {
        AuxAdministrativo logueado;
        SistemaDeInformacion s; 
        public AuxPrincipal(AuxAdministrativo a)
        {
            InitializeComponent();
            logueado = a;
            s = SistemaDeInformacion.sistema;
        }

        private void btnPropuestaAux_Click(object sender, EventArgs e)
        {
            AuxRegistrarPropuesta arp = new AuxRegistrarPropuesta(logueado, this);
            arp.Show();
        }

        public List<TrabajoDeGrado> listaDeTrabajos()
        {
            List<TrabajoDeGrado> tdg = s.ListaTrabajosDeGrado;

            return tdg;
        }

        private void btnProrrogaAux_Click(object sender, EventArgs e)
        {
            AuxRegistrarProrroga arp = new AuxRegistrarProrroga(logueado, this);
            arp.Show();
        }

        private void btnAsignaciónJur_Click(object sender, EventArgs e)
        {
            AuxAsignarJurados aaj = new AuxAsignarJurados(logueado,this);
            aaj.Show();
        }

        public List<Jurado> listaJurados()
        {
            return s.TotalJurados;
        }

       
    }
}
