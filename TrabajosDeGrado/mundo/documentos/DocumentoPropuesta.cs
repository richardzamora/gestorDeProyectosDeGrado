using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.documentos;

namespace TrabajosDeGrado
{
    public class DocumentoPropuesta : IDocumento
    {
        private DocumentoOficial _respuesta;

        public DocumentoPropuesta(string pCodigo, string pRuta, DateTime pFechaInicio, DateTime pFechaFinal)
            : base(pCodigo, pRuta, pFechaInicio, pFechaFinal)
        {  
            respuesta = null;
        }

        public DocumentoOficial respuesta
        {
            get { return _respuesta; }
            set { _respuesta = value; }
        }

    }
}
