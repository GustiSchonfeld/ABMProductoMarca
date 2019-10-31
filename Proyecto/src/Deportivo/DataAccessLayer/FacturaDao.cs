using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.Entities;
using System.Data;
using Deportivo.DataAccessLayer;

namespace Deportivo.DataAccessLayer
{
    class FacturaDao
    {
        internal bool Create(Factura factura)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[Facturas] ",
                                            "           ([nro_factura]   ",
                                            "           ,[fecha]         ",
                                            "           ,[cliente]       ",
                                            "           ,[tipoFactura]   ",
                                            "           ,[subtotal]    ",
                                            "           ,[descuento]    ",
                                            "           ,[borrado]      ",
                                            "           ,[formapago]    ",
                                            "           ,[tipotarjeta]    ",
                                            "           ,[tarjeta]      ",
                                            "           ,[nro_tarjeta]      ",
                                            "           ,[codigo])      ",
                                            "     VALUES                 ",
                                            "           (@nro_factura   ",
                                            "           ,@fecha          ",
                                            "           ,@cliente        ",
                                            "           ,@tipoFactura    ",
                                            "           ,@subtotal     ",
                                            "           ,@descuento     ",
                                            "           ,@borrado       ",
                                            "           ,@formapago     ",
                                            "           ,@tipotarjeta     ",
                                            "           ,@tarjeta       ",
                                            "           ,@nro_tarjeta       ",
                                            "           ,@codigo       )");


                var parametros = new Dictionary<string, object>();
                parametros.Add("nro_factura", factura.NroFactura);
                parametros.Add("fecha", factura.Fecha);
                parametros.Add("cliente", factura.Cliente.Id);
                parametros.Add("tipoFactura", factura.TipoFactura.IdTipoFactura);
                parametros.Add("subtotal", factura.SubTotal);
                parametros.Add("descuento", factura.Descuento);

                parametros.Add("formapago", factura.FormaPago);
                parametros.Add("tipotarjeta", factura.TipoTarjeta.IdTipo);
                parametros.Add("tarjeta", factura.Tarjeta.IdTarjeta);
                parametros.Add("nro_tarjeta", factura.NroTarjeta);
                parametros.Add("codigo", factura.CodigoTarjeta);


                parametros.Add("borrado", false);
                dm.EjecutarSQLCONPARAMETROS(sql, parametros);

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.IdFactura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.FacturaDetalle)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[FacturasDetalle] ",
                                                        "           ([id_factura]           ",
                                                        "           ,[id_producto]          ",
                                                        "           ,[precio_unitario]      ",
                                                        "           ,[cantidad]             ",
                                                        "           ,[borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_producto           ",
                                                        "           ,@precio_unitario       ",
                                                        "           ,@cantidad              ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura", factura.IdFactura);
                    paramDetalle.Add("id_producto", itemFactura.IdProducto);
                    paramDetalle.Add("precio_unitario", itemFactura.PrecioUnitario);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("borrado", false);

                    dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
                }



                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }
    }
}
