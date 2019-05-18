using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    [Serializable]
    public class DocumentoOficial
    {
        private String codigo;
        private DateTime fechaPublicacion;
        private String rutaArchivo;

        public DocumentoOficial( DateTime fechaPublicacion)
        {
            codigo = fechaPublicacion.TimeOfDay.ToString() + fechaPublicacion.Day.ToString() + fechaPublicacion.Month.ToString() + fechaPublicacion.Year.ToString();
            this.fechaPublicacion = fechaPublicacion;
            this.rutaArchivo = @"C:\TrabajosDeGrado\ "+ codigo + ".docx";
        }

        #region getters and setters papu

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public DateTime FechaPublicacion
        {
            get
            {
                return fechaPublicacion;
            }

            set
            {
                fechaPublicacion = value;
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

        public static implicit operator DocumentoOficial(string v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
