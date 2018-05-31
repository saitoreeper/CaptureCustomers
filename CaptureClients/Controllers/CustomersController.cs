using CaptureClients.DataContexts;
using CaptureClients.Entities;
using CaptureClients.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CaptureClients.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            CustomersHelper Customer = new CustomersHelper();
            IEnumerable<Customer> customersList = Customer.GetCustomersList();

            return customersList;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            HttpResponseMessage request;
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