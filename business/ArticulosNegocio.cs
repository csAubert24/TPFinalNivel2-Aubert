using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data.SqlTypes;
using Dominio;


namespace business
{
      public class ArticulosNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl ,A.Precio, C.Descripcion categoria, M.Descripcion marca ,A.IdCategoria, A.IdMarca, A.Precio from MARCAS M,ARTICULOS C, ARTICULOS A where C.Id  = a.IdCategoria and M.Id  = a.IdMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];


                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.Url = (string)lector["ImagenUrl"];

                    aux.marca = new elemento();
                    aux.marca.Id = (int)lector["IdMarca"];
                    aux.marca.Descripcion = (string)lector["marca"];

                    aux.categoria = new elemento();
                    aux.categoria.Id = (int)lector["IdCategoria"];
                    aux.categoria.Descripcion = (string)lector["categoria"];

                    if (!(lector["Precio"]is DBNull))   
                        aux.precio = (Decimal)lector["Precio"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


            conexion.Close();
            return lista;    

            

        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,IdCategoria,IdMarca)values('"+nuevo.codigo+"','"+nuevo.nombre+"','"+nuevo.descripcion+"','"+nuevo.Url+"',@IdCategoria,@IdMarca)");
                acceso.setearParametro("@IdCategoria", nuevo.categoria.Id);
                acceso.setearParametro("@IdMarca", nuevo.marca.Id);
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }








    }
}
