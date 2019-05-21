using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    [Serializable]
    public class TrabajoDeGrado
    {
        public static String APROBACION = "En espera de aprobación";
        public static String DESARROLLO = "En proceso de desarrollo";
        public static String EVALUACION = "En proceso de evaluación";
        public static String FINALIZADA = "finalizada con mención";
        public static String CANCELADA = "En aprovacion";

        public static String LAUREADA = "Laureada";
        public static String MERITORIA = "Meritoria";

        private String codigo;
        private String titulo;
        private DateTime fechaInicio;
        private DateTime fechaSocializacion;
        private String tipoModalidad;
        private String estado;
        private String mencion;
        private List<Estudiante> estudiantes;
        private List<Jurado> juradosAsignados;
        private List<DocumentoPropuesta> documentosPropuesta;
        private List<DocumentoFinal> documentosFinales;
        private DocumentoProrroga documentosProrroga;

        #region getters and setters
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

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaSocializacion
        {
            get
            {
                return fechaSocializacion;
            }

            set
            {
                fechaSocializacion = value;
            }
        }

        public string TipoModalidad
        {
            get
            {
                return tipoModalidad;
            }

            set
            {
                tipoModalidad = value;
            }
        }

        internal List<Estudiante> Estudiantes
        {
            get
            {
                return estudiantes;
            }

            set
            {
                estudiantes = value;
            }
        }

        internal List<Jurado> JuradosAsignados
        {
            get
            {
                return juradosAsignados;
            }

            set
            {
                juradosAsignados = value;
            }
        }

        internal List<DocumentoPropuesta> DocumentosPropuesta
        {
            get
            {
                return documentosPropuesta;
            }

            set
            {
                documentosPropuesta = value;
            }
        }

        public List<DocumentoFinal> DocumentosFinales
        {
            get
            {
                return documentosFinales;
            }

            set
            {
                documentosFinales = value;
            }
        }

        public DocumentoProrroga DocumentosProrroga
        {
            get
            {
                return documentosProrroga;
            }

            set
            {
                documentosProrroga = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Mencion
        {
            get
            {
                return mencion;
            }

            set
            {
                mencion = value;
            }
        }
        #endregion

        public TrabajoDeGrado( Estudiante e,  String pTitulo, DateTime pFecha, String pTipoModalidad, DocumentoPropuesta dp)
        {
            estudiantes = new List<Estudiante>();
            juradosAsignados = new List<Jurado>();
            documentosPropuesta = new List<DocumentoPropuesta>();
            documentosFinales = new List<DocumentoFinal>();

            estudiantes.Add(e);
            codigo = pFecha.Minute.ToString()+pFecha.Hour+ pFecha.Day.ToString() + pFecha.Month.ToString() + pFecha.Year.ToString();
            titulo = pTitulo;
            fechaInicio = pFecha;
            tipoModalidad = pTipoModalidad;
            
            DocumentosPropuesta.Add(dp);
            estado = TrabajoDeGrado.APROBACION;
        }


        public void aprobarPropuesta(DocumentoOficial doc)
        {
            documentosPropuesta.Last<DocumentoPropuesta>().respuesta = doc;
            this.estado = TrabajoDeGrado.DESARROLLO;
        }

              
        public void entregarDocumentoFinal()
        {
            this.estado = TrabajoDeGrado.EVALUACION;
        }

        public void entregarDocumentoProrroga()
        {
            this.estado = TrabajoDeGrado.DESARROLLO;
            documentosPropuesta.Last<DocumentoPropuesta>().fechaFinal.AddDays(20);
        }

        public void aprobarDocumentoFinal(String mencion, DocumentoOficial doc)
        {
            documentosFinales.Last<DocumentoFinal>().archivoEvaluacion = doc;
            this.mencion = mencion;
            this.estado = TrabajoDeGrado.FINALIZADA;
        }

        public void reprobarDocumentoProrroga()
        {
            this.estado = TrabajoDeGrado.CANCELADA;
        }
    }
}
