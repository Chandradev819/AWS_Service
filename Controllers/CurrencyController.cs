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
        public async Task<object> Get(string fsym, string tsyms)
        {
            var result = await _currency.GetConveryValue(fsym, tsyms);
            return result;
        }
    }
}
