using CaptureClients.DataContexts;
using CaptureClients.Entities;
using CaptureClients.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace CaptureClients.Controllers
{
    [EnableCors(origins: "http://localhost:54362", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {

        // GET: api/Contacts/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetContacts()
        {            
                CustomersHelper Customer = new CustomersHelper();
                IEnumerable<Customer> customerList = Customer.GetCustomersList();

                return Ok(customerList);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomersHelper CustomerHelper = new CustomersHelper();
                CustomerHelper.SaveCustomer(customer);
                return this.Request.CreateResponse(HttpStatusCode.OK);
            }
            return this.Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}