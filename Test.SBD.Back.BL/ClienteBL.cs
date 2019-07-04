using System.Collections.Generic;
using Test.SBD.Back.DAL.EF.Repositories;
using Test.SBD.Back.Utilities.DTO;

namespace Test.SBD.Back.BL
{
    public class ClienteBL
    {
        /// <summary>
        /// returns all clients or specified
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ClienteDTO> GetAllOrById(long id = 0)
        {
            List<ClienteDTO> clienteDTOs = new ClienteRepository().GetAllOrById(id);
            return clienteDTOs;
        }

        /// <summary>
        /// Save a new client
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public int InsertCliente(ClienteDTO cliente)
        {
            int res = new ClienteRepository().InsertCliente(cliente);
            return res;
        }

        /// <summary>
        /// Update the data of the client
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public int UpdateCliente(ClienteDTO cliente)
        {
            int res = new ClienteRepository().UpdateCliente(cliente);
            return res;
        }

        /// <summary>
        /// Delete specified client
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCliente(long id)
        {
            var res = new ClienteRepository().DeleteCliente(id);
            return res;
        }
    }
}