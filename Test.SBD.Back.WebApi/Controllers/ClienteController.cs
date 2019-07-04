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
    public class ClienteController : ApiController
    {
        /// <summary>
        /// GET: api/Cliente
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            var listfac = JsonConvert.SerializeObject(new ClienteBL().GetAllOrById());
            return Ok(listfac);
        }

        /// <summary>
        /// GET: api/Cliente/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(long id)
        {
            var listfac = JsonConvert.SerializeObject(new ClienteBL().GetAllOrById(id));
            return Ok(listfac);
        }

        /// <summary>
        /// POST: /api/Cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void Post([FromBody] ClienteDTO cliente)
        {
            new ClienteBL().InsertCliente(cliente);
        }

        /// <summary>
        /// PUT: /api/Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Cliente"></param>
        public void Put([FromBody] ClienteDTO cliente)
        {
            new ClienteBL().UpdateCliente(cliente);
        }

        /// <summary>
        /// DELETE: /api/Cliente/5
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            new ClienteBL().DeleteCliente(id);
        }
    }
}
