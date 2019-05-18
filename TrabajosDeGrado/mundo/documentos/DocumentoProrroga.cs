using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosDeGrado.mundo.documentos;

namespace TrabajosDeGrado
{
    [Serializable]
    public class DocumentoProrroga : IDocumento
    {

        public DocumentoProrroga(string pCodigo, string pRuta, DateTime pFechaInicio, DateTime pFechaFinal)
            : base(pCodigo, pRuta, pFechaInicio, pFechaFinal)
        {
            
        }
    }
}
