using System;
using System.Collections.Generic;
using System.Linq;
using Test.SBD.Back.Utilities.DTO;

namespace Test.SBD.Back.DAL.EF.Repositories
{
    public class FacturaRepository
    {
        public List<FacturaDTO> GetAllOrById(int id = 0)
        {
            try
            {
                List<FacturaDTO> facturaDTOs = new List<FacturaDTO>();
                using (var context = new DataModelDB())
                {
                    List<Factura> listres = context.Facturas.ToList();

                    if (id > 0)
                    {
                        listres = listres.Where(fac => fac.Id.Equals(id)).ToList();
                    }

                    foreach (var factura in listres)
                    {
                        facturaDTOs.Add(new FacturaDTO
                        {
                            Id = factura.Id,
                            ClienteId = factura.ClienteId,
                            FechaVenta = factura.FechaVenta,
                            ValorTotal = factura.ValorTotal,
                            Estado = factura.Estado
                        });
                    }
                    return facturaDTOs;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<FacturaDTO> GetByClientId(long ClientId)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    List<FacturaDTO> facturaDTOs = new List<FacturaDTO>();
                    List<Factura> listres = context.Facturas.Where(fac => fac.ClienteId.Equals(ClientId)).ToList();

                    foreach (var factura in listres)
                    {
                        facturaDTOs.Add(new FacturaDTO
                        {
                            Id = factura.Id,
                            ClienteId = factura.ClienteId,
                            FechaVenta = factura.FechaVenta,
                            ValorTotal = factura.ValorTotal,
                            Estado = factura.Estado
                        });
                    }
                    return facturaDTOs;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int InsertFactura(FacturaDTO factura)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    context.Facturas.Add(new Factura
                    {
                        Id = factura.Id,
                        ClienteId = factura.ClienteId,
                        FechaVenta = DateTime.Now,
                        ValorTotal = factura.ValorTotal,
                        Estado = true
                    });

                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int UpdateFactura(FacturaDTO factura)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    var std = context.Facturas.Where(fac => fac.Id.Equals(factura.Id)).FirstOrDefault();
                    std.ClienteId = factura.ClienteId;
                    std.ValorTotal = factura.ValorTotal;
                    std.Estado = factura.Estado;
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteFactura(int id)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    var std = context.Facturas.Where(fac => fac.Id.Equals(id)).FirstOrDefault();
                    context.Facturas.Remove(std);
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}