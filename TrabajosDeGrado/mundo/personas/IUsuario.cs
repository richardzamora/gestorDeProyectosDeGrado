using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado.mundo.personas
{
    [Serializable]
    public class IUsuario
    {

        private string _nombre;
        private string _apellido;
        private string _usuario;
        private string _contraseña;

        public string apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public string contraseña
        {
            get
            {
                return _contraseña;
            }

            set
            {
                _contraseña = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public IUsuario(string pNombre, string pApellido, string pUsuario, string pContraseña)
        {
            nombre = pNombre;
            apellido = pApellido;
            usuario = pUsuario;
            contraseña = pContraseña;
        }
    }
}

