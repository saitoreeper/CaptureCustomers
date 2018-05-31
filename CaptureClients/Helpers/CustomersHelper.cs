using CaptureClients.DataContexts;
using CaptureClients.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CaptureClients.Helpers
{
   

    public class CustomersHelper
    {
        private CustomerCaptureDb db = new CustomerCaptureDb();

        public IEnumerable<Customer> GetCustomersList()
        {
            List<Customer> customersList = db.Customers.ToList();
            return customersList;
        }

        public void SaveCustomer(Customer customer)
        {            
                Customer addCustomer = new Customer()
                {
                    Name = customer.Name,
                    Latitude = customer.Latitude,
                    longitude = customer.longitude
                };

                db.Customers.Add(addCustomer);
                db.SaveChanges();
            }
        }
    }
