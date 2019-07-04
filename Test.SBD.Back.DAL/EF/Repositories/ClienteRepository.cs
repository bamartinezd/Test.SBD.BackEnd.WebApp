using System;
using System.Collections.Generic;
using System.Linq;
using Test.SBD.Back.Utilities.DTO;

namespace Test.SBD.Back.DAL.EF.Repositories
{
    public class ClienteRepository
    {
        public List<ClienteDTO> GetAllOrById(long id = 0)
        {
            try
            {
                List<ClienteDTO> ClienteDTOs = new List<ClienteDTO>();
                using (var context = new DataModelDB())
                {
                    List<Cliente> listres = context.Clientes.ToList();

                    if (id > 0)
                    {
                        listres = listres.Where(fac => fac.Id.Equals(id)).ToList();
                    }

                    foreach (var cliente in listres)
                    {
                        ClienteDTOs.Add(new ClienteDTO
                        {
                            Id = cliente.Id,
                            Nombre = cliente.Nombre,
                            Direccion = cliente.Direccion,
                            Estado = cliente.Estado,
                            FechaCreacion = cliente.FechaCreacion
                        });
                    }
                    return ClienteDTOs;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertCliente(ClienteDTO cliente)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    context.Clientes.Add(new Cliente
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Direccion = cliente.Direccion,
                        Estado = true,
                        FechaCreacion = DateTime.Now
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

        public int UpdateCliente(ClienteDTO cliente)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    var std = context.Clientes.Where(fac => fac.Id.Equals(cliente.Id)).FirstOrDefault();
                    std.Nombre = cliente.Nombre;
                    std.Direccion = cliente.Direccion;
                    std.Estado = true;
                    std.FechaCreacion = DateTime.Now;
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteCliente(long id)
        {
            try
            {
                using (var context = new DataModelDB())
                {
                    var std = context.Clientes.Where(fac => fac.Id.Equals(id)).FirstOrDefault();
                    context.Clientes.Remove(std);
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