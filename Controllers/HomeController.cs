using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AWS_Service.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<Emp> Get()
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp()
                {
                    Id=100,
                    EmpName="Chandradev",
                    EmpAddress="Bnaglore",
                     Country="India"
                },
                 new Emp()
                {
                    Id=101,
                    EmpName="Chandradev1",
                    EmpAddress="Bnaglore1",
                     Country="India1"
                },
                  new Emp()
                {
                    Id=102,
                    EmpName="Chandradev2",
                    EmpAddress="Bnaglore2",
                     Country="India2"
                }
            };
            return emps;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class Emp
        {
            public int Id { get; set; }
            public string EmpName { get; set; }
            public string EmpAddress { get; set; }
            public string Country { get; set; }
        }
    }
}
