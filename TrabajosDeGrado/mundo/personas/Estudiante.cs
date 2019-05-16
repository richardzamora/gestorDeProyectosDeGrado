using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.personas;

namespace TrabajosDeGrado
{
    public class Estudiante : Usuario
    {
 
        private int semestre;
        private String telefono;
        private String cedula;
        private Boolean multa;

        #region getters and setters papu
        
        public int Semestre
        {
            get
            {
                return semestre;
            }

            set
            {
                semestre = value;
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

        public bool Multa
        {
            get
            {
                return multa;
            }

            set
            {
                multa = value;
            }
        }

       
        #endregion

        public Estudiante(String pNombre, String pApellido, String pUsuario, int pSemeste, String pTelefono, String pCedula, Boolean pMulta, String pContraseña)
            : base(pNombre,pApellido, pUsuario, pContraseña)
        {
            
            semestre = pSemeste;
            telefono = pTelefono;
            cedula = pCedula;
            multa = pMulta;
            
        }

  
    }

}
