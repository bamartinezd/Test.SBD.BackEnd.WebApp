using System.Collections.Generic;
using Test.SBD.Back.DAL.EF.Repositories;
using Test.SBD.Back.Utilities.DTO;

namespace Test.SBD.Back.BL
{
    public class FacturaBL
    {
        /// <summary>
        /// returns all invoices or specified
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<FacturaDTO> GetAllOrById(int id = 0)
        {
            List<FacturaDTO> facturaDTOs = new FacturaRepository().GetAllOrById(id);
            return facturaDTOs;
        }

        /// <summary>
        /// Returns all invoices by client
        /// </summary>
        /// <param name="ClientId"></param>
        /// <returns></returns>
        public List<FacturaDTO> GetByClientId(long ClientId)
        {
            List<FacturaDTO> facturaDTOs = new FacturaRepository().GetByClientId(ClientId);
            return facturaDTOs;
        }

        /// <summary>
        /// Save a new invoice
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public int InsertFactura(FacturaDTO factura)
        {
            int res = new FacturaRepository().InsertFactura(factura);
            return res;
        }

        /// <summary>
        /// Update the data of the invoice
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public int UpdateFactura(FacturaDTO factura)
        {
            int res = new FacturaRepository().UpdateFactura(factura);
            return res;
        }

        /// <summary>
        /// Delete specified invoice
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFactura(int id)
        {
            var res = new FacturaRepository().DeleteFactura(id);
            return res;
        }
    }
}