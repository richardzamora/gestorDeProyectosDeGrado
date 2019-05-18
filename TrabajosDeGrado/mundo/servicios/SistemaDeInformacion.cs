using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeGrado
{
    [Serializable]
    public class SistemaDeInformacion
    {
        public static string FileName = @"../../../SavedSistemaInformacion.bin";

        public static SistemaDeInformacion sistema = new SistemaDeInformacion(FileName);
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
        public List<Estudiante> TotalEstudiantes
        {
            get
            {
                return totalEstudiantes;
            }
            set
            {
                totalEstudiantes = value;
            }
        }
        public List<AuxAdministrativo> TotalAdministrativos
        {
            get
            {
                return totalAdministrativos;
            }
            set
            {
                totalAdministrativos = value;
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

        public SistemaDeInformacion(string ruta)
        {
            SistemaDeInformacion data = cargarDatos(FileName);
            if (data == null)
            {
                TotalEstudiantes = new List<Estudiante>();
                ListaTrabajosDeGrado = new List<TrabajoDeGrado>();
                TotalJurados = new List<Jurado>();
                TotalAdministrativos = new List<AuxAdministrativo>();
            }
            else
            {
                TotalEstudiantes = data.TotalEstudiantes;
                ListaTrabajosDeGrado = data.ListaTrabajosDeGrado;
                TotalJurados = data.TotalJurados;
                TotalAdministrativos = data.TotalAdministrativos;
            }
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

        public static void guardarDatos(SistemaDeInformacion sistemaInfo, String ruta)
        {
            Stream SaveFileStream = File.Create(FileName);
            try
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, sistemaInfo);
            }
            catch (Exception)
            {
                Console.WriteLine("Error al guardar datos");

            }
            SaveFileStream.Close();
        }
        public static SistemaDeInformacion cargarDatos(String ruta)
        {
            if (File.Exists(FileName))
            {
                Stream openFileStream = File.OpenRead(FileName);
                try
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    SistemaDeInformacion sistemaInfo = (SistemaDeInformacion)deserializer.Deserialize(openFileStream);
                    openFileStream.Close();
                    return sistemaInfo;
                }
                catch
                {
                    openFileStream.Close();
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
