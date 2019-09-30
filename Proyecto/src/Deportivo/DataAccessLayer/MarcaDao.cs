

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

namespace Deportivo.DataAccessLayer
{
    public class MarcaDao
    {
        public IList<Marca> GetAll()
        {
            List<Marca> listadoMarcas = new List<Marca>();

            var strSql = "SELECT id_marca, descripcion from Marcas where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoMarcas.Add(MappingMarcas(row));
            }

            return listadoMarcas;
        }

        private Marca MappingMarcas(DataRow row)
        {
            Marca oMarca = new Marca
            {
                IdMarca = Convert.ToInt32(row["id_marca"].ToString()),
                Descripcion = row["descripcion"].ToString()
            };

            return oMarca;
        }

        public IList<Marca> GetMarcaByFiltersCondiciones(String condiciones)
        {
            List<Marca> listadoMarcas = new List<Marca>();
            String sqlcondiciones = condiciones;

            var strSql = String.Concat("SELECT m.id_marca," ,
                " m.descripcion ",
                " FROM Marcas as m ",
                " WHERE m.borrado=0 ");
          

            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY m.descripcion DESC";

            var resultadoConsulta = (DataRowCollection)DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoMarcas.Add(MappingMarcas(row));
            }

            return listadoMarcas;
        }
        public Marca GetMarcaById(int idMarca)
        {
            var strSql = String.Concat("SELECT m.id_marca, ",
                                      "        m.descripcion",
                                      "        FROM Marcas as m",
                                      " WHERE m.borrado=0 AND m.id_marca = " + idMarca.ToString());

            return MappingMarcas(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }


        internal bool Create(Marca oMarca)
        {
            string str_sql = "INSERT INTO Marcas (descripcion, borrado)" +
             " VALUES (" +
             "'" + oMarca.Descripcion + "'" + "," +
                  " 0 " +
                ")";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal bool Update(Marca oMarca)
        {

            string str_sql = "UPDATE Marcas " +
                             "SET descripcion=" + "'" + oMarca.Descripcion + "'" +
                     
                             " WHERE id_marca=" + oMarca.IdMarca;

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }


        internal bool Delete(Marca oMarca)
        {

            string str_sql = "UPDATE Marcas " +
                             "SET borrado=1 " +
                             " WHERE id_marca=" + oMarca.IdMarca;

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }

}