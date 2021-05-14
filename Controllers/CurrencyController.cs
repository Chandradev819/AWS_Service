using AWS_Service.Model;
using AWS_Service.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AWS_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrency _currency;

        public CurrencyController(ICurrency objCurrency)
        {
            _currency = objCurrency;
        }

        // GET: api/<CurrencyController>
        [HttpGet]
        public async Task<Root> Get()
        {
            var result = await _currency.GetConveryValue();
            return result;
        }
    }
}
