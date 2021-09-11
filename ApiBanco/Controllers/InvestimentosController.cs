using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBanco.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiBanco.Controllers
{
    [Route("api/contaInvestimento")]
    [ApiController]
    public class InvestimentosController : ControllerBase
    {
        // GET: api/<InvestimentosController>
        [HttpGet]
        public List<ContaInvestimentos> Get()
        {
            ContaInvestimentos cInvest = new ContaInvestimentos();
            return cInvest.ListarClientes();
        }

        // GET api/<InvestimentosController>/5
        [HttpGet("{id}")]
        public ContaInvestimentos Get(int id)
        {
            ContaInvestimentos cInvest = new ContaInvestimentos();
            var listContas = cInvest.ListarClientes();

            foreach (var conta in listContas)
            {
                if(conta.ID == id)
                {
                    cInvest = conta;
                    break;
                }
            }

            return cInvest;
        }

        // POST api/<InvestimentosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InvestimentosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvestimentosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
