﻿using CaptureClients.DataContexts;
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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {

        // GET: api/Customers/5
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
        [HttpPost()]
        public IHttpActionResult Post(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("FAILED");
            }
            CustomersHelper CustomerHelper = new CustomersHelper();
            CustomerHelper.SaveCustomer(customer);
            return Ok(customer);
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