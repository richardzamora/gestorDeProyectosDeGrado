using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.documentos;

namespace TrabajosDeGrado
{
    public class DocumentoFinal : IDocumento
    {
        private DocumentoOficial _archivoEvaluacion;
        public DocumentoFinal(string pCodigo, string pRuta, DateTime pFechaInicio, DateTime pFechaFinal)
            : base(pCodigo, pRuta, pFechaInicio, pFechaFinal)
        {

        }

        public DocumentoOficial archivoEvaluacion
        {
            get { return _archivoEvaluacion; }
            set { _archivoEvaluacion = value; }
        }
    }
}
