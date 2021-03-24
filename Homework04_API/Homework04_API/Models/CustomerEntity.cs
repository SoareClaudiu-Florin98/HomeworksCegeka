using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework04_API.Models
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public CarEntity car { get; set;  }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
