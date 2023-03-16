using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace bussines
{
    public class ElementoNegocio
    {
        public List<elemento> listar()
        {
            List<elemento> lista = new List<elemento>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearConsulta("select Id, Descripcion from MARCAS");
                Datos.ejecutarLectura();
                while (Datos.Lector.Read())
                {
                    elemento aux = new elemento();
                    aux.id = (int)Datos.Lector["Id"];
                    aux.descripcion = (string)Datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarConexion();

            }
        }
        public List<elemento> listar2()
        {
            List<elemento> lista = new List<elemento>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                Datos.ejecutarLectura();
                while (Datos.Lector.Read())
                {
                    elemento aux = new elemento();
                    aux.id = (int)Datos.Lector["Id"];
                    aux.descripcion = (string)Datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarConexion();

            }
        }
    }
}
