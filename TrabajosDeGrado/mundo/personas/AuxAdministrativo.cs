using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.personas;

namespace TrabajosDeGrado
{
    public class AuxAdministrativo : IUsuario
    {
        public AuxAdministrativo(String pNombre, String pApellido, String pUsuario, String pContraseña)
            :base(pNombre,pApellido, pUsuario, pContraseña)
        {
            
        }
    }   
}
