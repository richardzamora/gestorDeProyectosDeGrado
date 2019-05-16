using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.personas;

namespace TrabajosDeGrado
{
    public class Jurado : Usuario
    {
        public static String LIBRE = "Libre";
        public static String OCUPADO = "Ocupado";

       
        private int numeroTajetaProfecional;
        private String telefono;
        private String cedula;
        private String estado;

        #region getters and setters papu
       

        public int NumeroTajetaProfecional
        {
            get
            {
                return numeroTajetaProfecional;
            }

            set
            {
                numeroTajetaProfecional = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
        #endregion

        public Jurado(String pNombre, String pApellido, String pUsuario, int pnumeroTajetaProfecional, String pTelefono,  String pContraseña)
            :base(pNombre, pApellido, pUsuario, pContraseña)
        {
            numeroTajetaProfecional = pnumeroTajetaProfecional;
            telefono = pTelefono;
            estado = Jurado.LIBRE;
        }

    
    }
}
