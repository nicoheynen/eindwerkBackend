using eindwerkBackend.EF;
using eindwerkBackend.EF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace eindwerkBackend.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Products> Get()
        {
            List<Products> result = new List<Products>();

            using (var context = new EindwerkBackendContext())
            {
                result = context.Products.ToList();
            }
            return result;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
