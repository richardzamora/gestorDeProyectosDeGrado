using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    public class SistemaDeInformacion
    {
        public static SistemaDeInformacion sistema = new SistemaDeInformacion();
        public static SistemaDeInformacion Sistema { get { return sistema; } }

        #region getters and setters
        public List<TrabajoDeGrado> ListaTrabajosDeGrado
        {
            get
            {
                return listaTrabajosDeGrado;
            }

            set
            {
                listaTrabajosDeGrado = value;
            }
        }

        public List<Jurado> TotalJurados
        {
            get
            {
                return totalJurados;
            }

            set
            {
                totalJurados = value;
            }
        }
        #endregion

        private List<Estudiante> totalEstudiantes;
        private List<TrabajoDeGrado> listaTrabajosDeGrado;
        private List<Jurado> totalJurados;
        private List<AuxAdministrativo> totalAdministrativos;

        public SistemaDeInformacion()
        {
            totalEstudiantes = new List<Estudiante>();
            listaTrabajosDeGrado = new List<TrabajoDeGrado>();
            totalJurados = new List<Jurado>();
            totalAdministrativos = new List<AuxAdministrativo>();

    }
        #region añadir personas
        public void añadirEstudiante(String pNombre, String pApellido, String pCodigo, int pSemeste, String pTelefono, String pCedula, Boolean pMulta, String pContraseña)
        {
            Estudiante e = new Estudiante(pNombre, pApellido, pCodigo, pSemeste, pTelefono, pCedula, pMulta, pContraseña);
            totalEstudiantes.Add(e);
        }
        
        public void añadirAuxAdministrativo(String pNombre, String pApellido, String pCodigo, String pContraseña)
        {
            AuxAdministrativo a = new AuxAdministrativo(pNombre, pApellido,  pCodigo,  pContraseña);
            totalAdministrativos.Add(a);
        }

        public void añadirJurado(String pNombre, String pApellido, String pCodigo, int pnumeroTajetaProfecional, String pTelefono, String pContraseña)
        {
            Jurado j = new Jurado(pNombre, pApellido, pCodigo, pnumeroTajetaProfecional, pTelefono, pContraseña);
            totalJurados.Add(j);
        }
        #endregion

        #region Inicio de sesión
        public Estudiante existeEstudiante(String codigo, String contraseña)
        {
            Estudiante es = null;
            for (int i = 0; i< totalEstudiantes.Count;i++)
            {
                if(totalEstudiantes[i].usuario.Equals(codigo) && totalEstudiantes[i].contraseña.Equals(contraseña))
                {
                    es = totalEstudiantes[i];
                    break;
                }
            }

            return es;
        }

        public Jurado existeJurado(String codigo, String contraseña)
        {
            Jurado es = null;
            for (int i = 0; i < totalJurados.Count; i++)
            {
                if (totalJurados[i].usuario.Equals(codigo) && totalJurados[i].contraseña.Equals(contraseña))
                {
                    es = totalJurados[i];
                    break;
                }
            }

            return es;
        }

        public AuxAdministrativo existeAdminitrativo(String codigo, String contraseña)
        {
            AuxAdministrativo es = null;
            for (int i = 0; i < totalAdministrativos.Count; i++)
            {
                if (totalAdministrativos[i].usuario.Equals(codigo) && totalAdministrativos[i].contraseña.Equals(contraseña))
                {
                    es = totalAdministrativos[i];
                    break;
                }
            }

            return es;
        }
        #endregion

        public void crearDocumentoPropuesta(Estudiante e, String titulo, String ruta, String modalidad, DateTime fecha)
        {
            DocumentoPropuesta dp = new DocumentoPropuesta(fecha.ToString(), ruta,fecha, fecha.AddDays(20));
            TrabajoDeGrado tg = new TrabajoDeGrado(e,titulo, fecha, modalidad, dp);
            listaTrabajosDeGrado.Add(tg);
           
        }

        public void crearDocumentoFinal(Estudiante e, String titulo, String ruta, String modalidad, DateTime fecha)
        {
            DocumentoFinal dp = new DocumentoFinal(fecha.ToString(), ruta, fecha, fecha);
            TrabajoDeGrado tg = buscarTrabajoDeGrado(e);
            tg.DocumentosFinales.Add(dp);
            tg.entregarDocumentoFinal();
            
        }

        public void crearDocumentoProrroga(Estudiante e, String titulo, String ruta, String modalidad, DateTime fecha)
        {
            DocumentoProrroga dp = new DocumentoProrroga(fecha.ToString(), ruta, fecha, fecha);
            TrabajoDeGrado tg = buscarTrabajoDeGrado(e);
            tg.DocumentosProrroga = dp;
            

        }

        private TrabajoDeGrado buscarTrabajoDeGrado(Estudiante e)
        {
            for (int i = 0; i < listaTrabajosDeGrado.Count(); i++)
            {
                for (int j = 0; j <listaTrabajosDeGrado.Count(); j++)
                {
                    if ( listaTrabajosDeGrado[i].Estudiantes[j] == e)
                    {
                        return listaTrabajosDeGrado[i];
                    }
                }
            }

            return null;
        }

    }
}
