using CaptureClients.DataContexts;
using CaptureClients.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptureClients.Helpers
{
    public class ContactsHelper
    {
        private CustomerCaptureDb db = new CustomerCaptureDb();

        public IEnumerable<Contact> GetContactsList(int id)
        {
            List<Contact> contactsList = db.Contacts.Where(c => c.CustomerId == id).ToList();
            return contactsList;
        }
    }
}