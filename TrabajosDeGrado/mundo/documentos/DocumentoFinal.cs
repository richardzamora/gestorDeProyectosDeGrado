using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    public class DocumentoFinal
    {
        
        private DateTime fechaEntrega;
        private DateTime fechaEvaluacion;
        private String rutaArchivo;
        private DocumentoOficial archivoEvaluacion;
        
        public DocumentoFinal(DateTime fecha, String pRutaArchivo)
        {
            this.fechaEntrega = fecha;
            fechaEvaluacion = fecha.AddDays(20);
            rutaArchivo = pRutaArchivo;
        }

        #region getters and setters papu
               

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

        public DocumentoOficial ArchivoEvaluacion
        {
            get
            {
                return archivoEvaluacion;
            }

            set
            {
                archivoEvaluacion = value;
            }
        }
        #endregion
    }
}
