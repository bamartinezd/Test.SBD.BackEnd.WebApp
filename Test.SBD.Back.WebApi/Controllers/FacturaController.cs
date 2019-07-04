using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.SBD.Back.BL;
using Test.SBD.Back.Utilities.DTO;

namespace Test.SBD.Back.WebApi.Controllers
{
    public class FacturaController : ApiController
    {
        /// <summary>
        /// GET: api/Factura
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            var listfac = JsonConvert.SerializeObject(new FacturaBL().GetAllOrById());
            return Ok(listfac);
        }

        /// <summary>
        /// GET: api/Factura/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            var listfac = JsonConvert.SerializeObject(new FacturaBL().GetAllOrById(id));
            return Ok(listfac);
        }

        /// <summary>
        /// GET: api/Factura/GetByClientId/1023931285
        /// </summary>
        /// <param name="ClientId"></param>
        /// <returns></returns>
        public IHttpActionResult GetByClientId(long ClientId)
        {
            var listfac = JsonConvert.SerializeObject(new FacturaBL().GetByClientId(ClientId));
            return Ok(listfac);
        }

        /// <summary>
        /// POST: /api/Factura
        /// </summary>
        /// <param name="factura"></param>
        public void Post([FromBody] FacturaDTO factura)
        {
            new FacturaBL().InsertFactura(factura);
        }

        /// <summary>
        /// PUT: /api/Factura
        /// </summary>
        /// <param name="id"></param>
        /// <param name="factura"></param>
        public void Put([FromBody] FacturaDTO factura)
        {
            new FacturaBL().UpdateFactura(factura);
        }

        /// <summary>
        /// DELETE: /api/Factura/5
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            new FacturaBL().DeleteFactura(id);
        }
    }
}
