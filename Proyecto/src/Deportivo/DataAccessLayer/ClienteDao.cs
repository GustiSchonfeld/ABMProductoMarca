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
    public class ClienteDao
    {
        public IList<Cliente> GetAll()
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            var strSql = "SELECT id,apellido,nombre,cuit from Clientes where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoClientes.Add(MappingClientes(row));
            }

            return listadoClientes;
        }

        private Cliente MappingClientes(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                Apellido = row["apellido"].ToString(),
                Nombre = row["nombre"].ToString(),
                Cuit = row["cuit"].ToString()
            };

            return oCliente;
        }

        public IList<Cliente> GetClienteByFiltersCondiciones(String condiciones)
        {
            List<Cliente> listadoClientes = new List<Cliente>();
            String sqlcondiciones = condiciones;

            var strSql = String.Concat("SELECT c.id,",
                "c.apellido,","c.nombre,","c.cuit",
                " FROM Clientes as c ",
                " WHERE c.borrado=0 ");


            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY c.apellido DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoClientes.Add(MappingClientes(row));
            }

            return listadoClientes;
        }
        public Cliente GetClienteById(int idCliente)
        {
            var strSql = String.Concat("SELECT c.id, ",
                                      "        c.apellido,","c.nombre,","c.cuit",
                                      "        FROM Clientes as c",
                                      " WHERE c.borrado=0 AND c.id = " + idCliente.ToString());

            return MappingClientes(DataManager.GetInstance().ConsultaSQL(strSql).Rows[0]);
        }

        
        internal bool Create(Cliente oCliente)
        // INSERT INTO Clientes (apellido,nombre,cuit,borrado) VALUES ('Casco','Milton','20-35470981-7',0)
        {
           

                try
                    
                {     
                     string str_sql = "INSERT INTO Clientes (apellido,nombre,cuit,borrado)" +
             " VALUES (" +
             "'" + oCliente.Apellido + "'" + "," +
             "'" + oCliente.Nombre + "'" + "," +
             "'" + oCliente.Cuit + "'" + "," +
             "0" +
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

            
        internal bool Update(Cliente oCliente)
        {

            try
            {
                string str_sql = "UPDATE Clientes " +
                             "SET apellido =" + "'" + oCliente.Apellido + "'" +
                             "," + "nombre =" + "'" + oCliente.Nombre + "'" +
                             "," + "cuit =" + "'" + oCliente.Cuit + "'" +
                             " WHERE id =" + oCliente.Id;


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


        internal bool Delete(Cliente oCliente)
        {
          try
            {
                string str_sql = "UPDATE Clientes " +
                             "SET borrado=1 " +
                             " WHERE id =" + oCliente.Id;


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