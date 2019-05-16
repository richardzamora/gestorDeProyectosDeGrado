using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    public class DocumentoProrroga
    {
        DateTime fechaEntrega;
        private String rutaArchivo;

        public DocumentoProrroga(DateTime fecha, String pRutaArchivo)
        {
            this.fechaEntrega = fecha;
            rutaArchivo = pRutaArchivo;
        }
              

        #region getters and setters

        public string RutaArchivo
        {
            get
            {
                return rutaArchivo;
            }

            set
            {
                rutaArchivo = value;
            }
        }

        public DateTime FechaEntrega
        {
            get
            {
                return fechaEntrega;
            }

            set
            {
                fechaEntrega = value;
            }
        }
        #endregion


    }
}
