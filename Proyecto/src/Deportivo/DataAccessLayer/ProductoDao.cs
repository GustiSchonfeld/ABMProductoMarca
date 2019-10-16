

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Deportivo.Entities;
using System.Data;
using Deportivo.DataAccessLayer;

namespace Deportivo.DataAccessLayer
{
    public class ProductoDao
    {
        public IList<Producto> GetAll()
        {
            List<Producto> listadoProductos = new List<Producto>();

           // var strSql = "SELECT id_producto as id, nombre, precio_venta , id_marca FROM Productos WHERE borrado = 0";
            //var strSql = String.Concat("SELECT producto.id_producto as id, ",
            //                         "        producto.nombre,",
            //                         "        producto.id_marca,",
           //                          "        marca.descripcion as marca, ",
           //                          "        producto.cantidad, ",
           //                          "        producto.precio_venta, ",
           //                          "        producto.fecha_alta",
           //                          "        FROM Productos as producto",
           //                          "  INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca",
            //                         " WHERE producto.borrado=0 ") ;
            var strSql = "SELECT producto.id_producto as id, ";
             strSql += " producto.nombre," ;
             strSql += " producto.id_marca," ;
             strSql += " marca.descripcion as marca, " ;
             strSql += " producto.cantidad, " ;
             strSql += " producto.precio_venta, " ;
             strSql += " producto.fecha_alta" ;
             strSql += " FROM Productos as producto" ;
             strSql += " INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca" ;
             strSql += " WHERE producto.borrado=0 " ;
            // resultadoConsulta contiene la tabla de resultado de ejecutar el select
             var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            // recorre cada una de las filas del resultado del select
            foreach (DataRow row in resultadoConsulta.Rows)
            {

                // Agrega un producto a la lista de productos
                listadoProductos.Add(MappingProducto(row));
            }

            return listadoProductos;
        }
        public Producto GetProductoById(int idProducto)
        {
            var strSql = String.Concat("SELECT producto.id_producto as id, ",
                                      "        producto.nombre,",
                                      "        producto.id_marca,",
                                      "        marca.descripcion as marca, ",
                                      "        producto.cantidad, ",
                                      "        producto.precio_venta, ",
                                      "        producto.fecha_alta",
                                      "        FROM Productos as producto",
                                      "  INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca",
                                      " WHERE producto.borrado=0 AND producto.id_producto = " + idProducto.ToString());


            return MappingProducto(DataManager.GetInstance().ConsultaSQL(strSql).Rows[0]);
        
        }

        public IList<Producto> GetProductoByFiltersCondiciones(String condiciones)
        {
            List<Producto> listadoProductos = new List<Producto>();
            String sqlcondiciones = condiciones;

            var strSql = String.Concat("SELECT producto.id_producto as id, ",
                                      "        producto.nombre,",
                                      "        producto.id_marca,",
                                      "        marca.descripcion as marca, ",
                                      "        producto.cantidad,",
                                      "        producto.precio_venta, ",
                                      "        producto.fecha_alta",
                                      "        FROM Productos as producto",
                                      "  INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca",
                                      " WHERE producto.borrado=0 ");

            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY producto.nombre DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoProductos.Add(MappingProducto(row));
            }

            return listadoProductos;
        }
        

        // Recibe cada fila del select y devuelve un objeto producto completo
        private Producto MappingProducto(DataRow row)
        {   // Crea una instancia oProducto del tipo Producto y la completa con sus datos
            Producto oProducto = new Producto();
            //oProducto es el objeto instanciado
            //oProducto.IdProducto donde IdProducto es el nombre de la propiedad en entity
            //Convert.ToInt32(row["id_producto"].ToString());  convierte a entero, doble o fecha lo que obtuvo en el select
            oProducto.IdProducto = Convert.ToInt32(row["id"].ToString());
            oProducto.Nombre = row["nombre"].ToString();

            oProducto.Marca = new Marca();
            //convierte a entero
            oProducto.Marca.IdMarca = Convert.ToInt32(row["id_marca"].ToString());
            //no es necesario convertir
            oProducto.Marca.Descripcion = row["marca"].ToString();

            oProducto.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
            //convierte a doble
            oProducto.Precio_Venta = Convert.ToDouble(row["precio_venta"].ToString());
            //convierte a fecha
            oProducto.Fecha_Alta = Convert.ToDateTime(row["fecha_alta"].ToString());

            return oProducto;
        }


        internal bool Create(Producto oProducto)
        {
           
            try
            {

                string str_sql = "INSERT INTO Productos (nombre, id_marca, cantidad, precio_venta,fecha_alta, borrado)" +
             " VALUES (" +
             "'" + oProducto.Nombre + "'" + "," +
             oProducto.Marca.IdMarca + "," +
              oProducto.Cantidad + "," +
               oProducto.Precio_Venta + "," +
                "getdate()" + "," +
               " 0 " +
                ")";

                return (DataManager.GetInstance().EjecutarSQL(str_sql) == 1);
                
            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {
              
            }
        }

        internal bool Update(Producto oProducto)
        {
            
            try
            {

                string str_sql = "UPDATE Productos " +
                             "SET nombre=" + "'" + oProducto.Nombre + "'" + "," +
                             " cantidad=" + oProducto.Cantidad + "," +
                             " precio_venta=" + oProducto.Precio_Venta + "," +
                    //" fecha_alta=" + "'" + oProducto.Fecha_Alta + "'" + "," +
                             " id_marca=" + oProducto.Marca.IdMarca +
                             " WHERE id_producto=" + oProducto.IdProducto;


                return (DataManager.GetInstance().EjecutarSQL(str_sql) == 1);
            }
            catch (Exception ex)
            {

                 return false;

            }
            finally
            {
                // Cierra la conexión
               
            }
        }


        internal bool Delete(Producto oProducto)
        {
              try
            {

                string str_sql = "UPDATE Productos " +
                             "SET borrado=1 " +
                             " WHERE id_producto=" + oProducto.IdProducto;

                return (DataManager.GetInstance().EjecutarSQL(str_sql) == 1);

             
            }
            catch (Exception ex)
            {

               
                return false;

            }
            finally
            {
                // Cierra la conexión
                
            }
        }
    }

}