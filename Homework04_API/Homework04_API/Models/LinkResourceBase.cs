using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework04_API.Models
{
    public class LinkResourceBase
    {
        public LinkResourceBase()
        {
        }
        public  List<Link> Links { get; set; } = new List<Link>()
        {
            new Link()
            {
                Href = "https://localhost:44359/customers",
                Method= "GET",
                Rel= "self"
            },
            new Link()
            {
                Href = "https://localhost:44359/customers/filter",
                Method= "GET",
                Rel= "filter_customer"                
            },
            new Link()
            {
                Href = "https://localhost:44359/customers/filter",
                Method= "GET",
                Rel= "filter_customer"
                
            },
            new Link()
            {
                Href = "https://localhost:44359/customers/customers/{id}",
                Method= "GET",
                Rel= "get_customer_by_if"
            },
            new Link()
            {
                Href = "https://localhost:44359/customers/customers",
                Method= "POST",
                Rel= "post_customer"
            },
            new Link()
            {
                Href = "https://localhost:44359/customer/{id}",
                Method= "PUT",
                Rel= "update_customer"
            },
        }; 

    }
}
