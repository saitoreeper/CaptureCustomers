using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptureClients.Entities
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string longitude { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
