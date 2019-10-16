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
using Microsoft.VisualBasic;
using Deportivo.Entities;
using System.Data;
using Deportivo.DataAccessLayer;

namespace Deportivo.DataAccessLayer
{
    public class TarjetaDao
    {
        public IList<Tarjeta> GetAll()
        {
           List<Tarjeta> listadoTarjetas = new List<Tarjeta>();
            // Consuta a la BD para obtener tarjetas y tipo tarjeta
           // SELECT ta.id,
           //ta.nombre,
           //ta.descripcion,
            //ta.tipotarjeta as tipo,   t.descripcion as destipo
           //FROM Tarjetas as ta
           //INNER JOIN TiposTarjeta as t ON  ta.TipoTarjeta = t.id
           //WHERE ta.borrado=0
            var strSql = "SELECT ta.id, ta.nombre, ta.descripcion, ta.tipotarjeta as tipo,  t.descripcion as destipo";
           strSql += " FROM Tarjetas as ta";
           strSql += " INNER JOIN TiposTarjeta as t ON  ta.TipoTarjeta = t.id";
           strSql += " WHERE ta.borrado=0";
            // resultadoConsulta contiene la tabla de resultado de ejecutar el select
           var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            // recorre cada una de las filas del resultado del select
            foreach (DataRow row in resultadoConsulta.Rows)
            {

                // Agrega un producto a la lista de productos
                listadoTarjetas.Add(MappingTarjeta(row));
            }

            return listadoTarjetas;
        }
        
        public Tarjeta GetTarjetaById(int idTarjeta)
        {
            var strSql = "SELECT ta.id, ta.nombre, ta.descripcion, ta.tipotarjeta as tipo,t.descripcion as destipo";
            strSql += " FROM Tarjetas as ta";
            strSql += " INNER JOIN TiposTarjeta as t ON  ta.TipoTarjeta = t.id";
            strSql += " WHERE ta.borrado=0 AND ta.id = ";
            strSql += idTarjeta.ToString();


            return MappingTarjeta(DataManager.GetInstance().ConsultaSQL(strSql).Rows[0]);

        }

        public IList<Tarjeta> GetTarjetaByFiltersCondiciones(String condiciones)
        {
            List<Tarjeta> listadoTarjetas = new List<Tarjeta>();
            String sqlcondiciones = condiciones;

            var strSql = "SELECT ta.id,";
            strSql += " ta.nombre,";
            strSql += " ta.descripcion,";
            strSql += " ta.tipotarjeta as tipo,";
            strSql += " t.descripcion as destipo";
            strSql += " FROM Tarjetas as ta";
            strSql += " INNER JOIN TiposTarjeta as t ON  ta.TipoTarjeta = t.id";
            strSql += " WHERE ta.borrado=0";

            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY ta.nombre DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoTarjetas.Add(MappingTarjeta(row));
            }

            return listadoTarjetas;
        }
              

        // Recibe cada fila del select y devuelve un objeto producto completo
        private Tarjeta MappingTarjeta(DataRow row)
        {   // Crea una instancia oProducto del tipo Producto y la completa con sus datos
            Tarjeta oTarjeta = new Tarjeta();
            //oProducto es el objeto instanciado
            //oProducto.IdProducto donde IdProducto es el nombre de la propiedad en entity
            //Convert.ToInt32(row["id_producto"].ToString());  convierte a entero, doble o fecha lo que obtuvo en el select
            oTarjeta.IdTarjeta = Convert.ToInt32(row["id"].ToString());
            oTarjeta.Nombre = row["nombre"].ToString();
            oTarjeta.Descripcion = row["descripcion"].ToString();
             
            oTarjeta.TipoTarjeta = new TipoTarjeta();
            oTarjeta.TipoTarjeta.IdTipo = Convert.ToInt32(row["tipo"].ToString());
            oTarjeta.TipoTarjeta.Descripcion = row["destipo"].ToString();
               

            return oTarjeta;
        }


        internal bool Create(Tarjeta oTarjeta)
        {
            
            try
            {

                string str_sql = "INSERT INTO Tarjetas (nombre, descripcion, tipotarjeta, borrado)" +
             " VALUES (" +
             "'" + oTarjeta.Nombre + "'" + "," +
             oTarjeta.Descripcion + "," +
             oTarjeta.TipoTarjeta.IdTipo + "," +
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
                // Cierra la conexión
              
            }
        }

        internal bool Update(Tarjeta oTarjeta)
        {

            try
            {

                string str_sql = "UPDATE Tarjetas " +
                             "SET nombre=" + "'" + oTarjeta.Nombre + "'" + "," +
                             " descripcion=" + oTarjeta.Descripcion + "," +
                             " tipotarjeta=" + oTarjeta.TipoTarjeta.IdTipo + "," +
                    //" fecha_alta=" + "'" + oProducto.Fecha_Alta + "'" + "," +
                             
                             " WHERE idTarjeta=" + oTarjeta.IdTarjeta;

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


        internal bool Delete(Tarjeta oTarjeta)
        {
            DataManager dm = new DataManager();

            try
            {

                string str_sql = "UPDATE Tarjetas " +
                             "SET borrado=1 " +
                             " WHERE idTarjeta=" + oTarjeta.IdTarjeta;


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
