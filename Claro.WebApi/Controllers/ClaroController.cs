using Claro.Application.Interfaces;
using Claro.Domain.Entities;
using Claro.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Claro.WebApi.Controllers
{
    [RoutePrefix("claro/mobile")]
    public class ClaroController : ApiController
    {
        private readonly ICelularAppService _celularAppService;

        public ClaroController(ICelularAppService celularAppService)
        {
            _celularAppService = celularAppService;
        }

        // GET: claro/mobile
        [Route("")]
        public IEnumerable<Celular> Get()
        {

            var celular = _celularAppService.GetAll();

            return celular;
        }

        // GET: claro/mobile/5
        [Route("{id:int}")]
        public Celular Get(int id)
        {
            var celular = _celularAppService.GetById(id);

            return celular;
        }

        // POST: claro/mobile
        [Route("")]
        public void Post([FromBody]Celular celular)
        {
            _celularAppService.Add(celular);
        }

        // PUT: claro/mobile/5
        [Route("{id:int}")]
        public void Put(int id, [FromBody]Celular celular)
        {
            _celularAppService.Update(celular);
        }

        // DELETE: claro/mobile
        [Route("")]
        public void Delete([FromBody]Celular celular)
        {
            _celularAppService.Remove(celular);
        }
    }

}
