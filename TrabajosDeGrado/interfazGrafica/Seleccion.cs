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
    public partial class Seleccion : Form
    {
        private SistemaDeInformacion s;

        public Seleccion()
        {
            InitializeComponent();

            s = SistemaDeInformacion.Sistema;

            s.añadirEstudiante("Richard", "Zamora", "2220171018", 5, "3183769455", "1234645197", false, "1234");
            s.añadirEstudiante("Lina Vanessa", "Rincón Salazar", "2220191005", 6, "00000000", "1110581308", false, "1234");
            s.añadirEstudiante("Exekielh", "Merstro Brunxstror", "2220151022", 7, "312432237", "1234653454", false, "1234");

            s.añadirAuxAdministrativo("Celeste", "Espinoza", "123456789", "1234");

            s.añadirJurado("Roberto", "Díaz", "987654321", 523476, "3253465643", "1234");
        }

        private void btnJurado_Click(object sender, EventArgs e)
        {
            validarUsuario();
            
        }

        private void validarUsuario()
        {
            if(s.existeEstudiante(txbUsuario.Text, txbContraseña.Text) != null)
            {
                EstudiantePrincipal es = new EstudiantePrincipal(s.existeEstudiante(txbUsuario.Text, txbContraseña.Text));
                es.Show();
                return;
            }
            if (s.existeJurado(txbUsuario.Text, txbContraseña.Text)!=null)
            {
                JuradoPrincipal es = new JuradoPrincipal(s.existeJurado(txbUsuario.Text, txbContraseña.Text));
                es.Show();
                return;
            }
            if (s.existeAdminitrativo(txbUsuario.Text, txbContraseña.Text)!=null)
            {
                AuxPrincipal es = new AuxPrincipal(s.existeAdminitrativo(txbUsuario.Text, txbContraseña.Text));
                es.Show();
                return;
            }
            
            MessageBox.Show("El usuario y/o la contraseña son incorrectos >:(");
        }
    }
}
