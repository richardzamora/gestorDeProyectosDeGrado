using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado.mundo.documentos
{
    [Serializable]
    public class IDocumento
    {
        public const string APROBADO = "aprobado";
        public const string DEVUELTO_PARA_CORRECCIONES = "devuelto";
        public const string RECHAZADO = "rechazada";
        public const string EN_ESPERA = "espera"; 

        private string _codigo;
        private string _ruta;
        private DateTime _fechaInicio;
        private DateTime _fechaFinal;
        private string _estado;

        public IDocumento (string pCodigo, string pRuta, DateTime pFechaInicio, DateTime pFechaFinal)
        {
            codigo = pCodigo;
            ruta = pRuta;
            fechaInicio = pFechaInicio;
            fechaFinal = pFechaFinal;
            estado = IDocumento.EN_ESPERA;

        }

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }

        public DateTime fechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime fechaFinal
        {
            get { return _fechaFinal; }
            set { _fechaFinal = value; }
        }

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
