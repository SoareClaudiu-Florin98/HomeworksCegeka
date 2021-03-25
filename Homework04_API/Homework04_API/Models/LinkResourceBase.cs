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
                Href = "https://localhost:44359/cars",
                Method= "GET",
                Rel= "get_all_cars"
                
            },
            new Link()
            {
                Href = "https://localhost:44359/cars",
                Method= "POST",
                Rel= "insert_car"
                
            },
            new Link()
            {
                Href = "https://localhost:44359/cars/{model}",
                Method= "POST",
                Rel= "update_car"
            },

            new Link()
            {
                Href = "https://localhost:44359/customers",
                Method= "GET",
                Rel= "get_all_costumers"
            },
            new Link()
            {
                Href = "https://localhost:44359/customers/filter",
                Method= "GET",
                Rel= "filter_customer_by_firstName"                
            },

            new Link()
            {
                Href = "https://localhost:44359/customers/customers",
                Method= "POST",
                Rel= "insert_customer"
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
