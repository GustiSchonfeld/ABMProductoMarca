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
    public class TipoTarjetaDao
    {
        public IList<TipoTarjeta> GetAll()
        {
            List<TipoTarjeta> listadoTipoTarjeta = new List<TipoTarjeta>();

            var strSql = "SELECT Id, Descripcion from TiposTarjeta where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTipoTarjeta.Add(MappingTipo(row));
            }

            return listadoTipoTarjeta;
        }

        private TipoTarjeta MappingTipo(DataRow row)
        {
            TipoTarjeta oTipoTarjeta = new TipoTarjeta();
            {
                oTipoTarjeta.IdTipo = Convert.ToInt32(row["Id"].ToString());
                oTipoTarjeta.Descripcion = row["Descripcion"].ToString();
            }

           return oTipoTarjeta;
        }

        public IList<TipoTarjeta> GetTipoTarjetaByFiltersCondiciones(String condiciones)
        {
            List<TipoTarjeta> listadoTipoTarjeta = new List<TipoTarjeta>();
            String sqlcondiciones = condiciones;

            var strSql = String.Concat("SELECT t.id,",
                " t.descripcion ",
                " FROM TipoTarjeta as t ",
                " WHERE t.borrado=0 ");
            
            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY t.descripcion DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoTipoTarjeta.Add(MappingTipo(row));
            }

            return listadoTipoTarjeta;
        }
        public TipoTarjeta GetTipoTById(int idTipoTarjeta)
        {
            var strSql = String.Concat("SELECT t.id, ",
                                      "        t.descripcion",
                                      "        FROM TipoTarjeta as t",
                                      " WHERE t.borrado=0 AND t.id = " + idTipoTarjeta.ToString());

            return MappingTipo(DataManager.GetInstance().ConsultaSQL(strSql).Rows[0]);
        }

       internal bool Create(TipoTarjeta oTipoTarjeta)
        {

           try
            {

                string str_sql = "INSERT INTO TipoTarjeta (descripcion, borrado)" +
              " VALUES (" +
              "'" + oTipoTarjeta.Descripcion + "'" + "," +
                   " 0 " +
                 ")";

                return (DataManager.GetInstance().EjecutarSQL(str_sql) == 1);

            }
            catch (Exception ex)
            {

                return false;

            }
            

        }

        internal bool Update(TipoTarjeta oTipoTarjeta)
        {   // crea una nueva instancia de data manager 

                       try
            {

                string str_sql = "UPDATE TipoTarjeta " +
                             "SET descripcion=" + "'" + oTipoTarjeta.Descripcion + "'" +

                             " WHERE id=" + oTipoTarjeta.IdTipo;
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


        internal bool Delete(TipoTarjeta oTipoTarjeta)
        {
               try
            {

                string str_sql = "UPDATE TipoTarjeta " +
                             "SET borrado=1 " +
                             " WHERE id= " + oTipoTarjeta.IdTipo;

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
