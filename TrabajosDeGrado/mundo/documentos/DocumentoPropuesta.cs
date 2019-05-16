using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    public class DocumentoPropuesta
    {  
        private DateTime fecha;
        private DateTime fechaLimiteEntregaResultado;
        private String rutaArchivo;
        private DocumentoOficial respuesta;

        public DocumentoPropuesta( DateTime pFecha, DateTime pFechalimite, String ruta)
        {  
            fecha = pFecha;
            fechaLimiteEntregaResultado = pFechalimite;
            rutaArchivo = ruta;
            respuesta = null;
        }

        #region getters and setters
        

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public DateTime FechaLimiteEntregaResultado
        {
            get
            {
                return fechaLimiteEntregaResultado;
            }

            set
            {
                fechaLimiteEntregaResultado = value;
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

        public DocumentoOficial Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }


        #endregion


    }
}
