using Homework04_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework04_API.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static List<CustomerEntity> _customers =  new List<CustomerEntity>();



        [HttpGet]
        [Route("customers")]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customers);

        }
        [HttpGet]
        [Route("customers/filter")]
        public IActionResult GetCustomersByCarModel(string model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var customers = _customers.FindAll(x => x.car.Model == model);

            return Ok(customers);

        }
        [HttpGet]
        [Route("customers/{id}")]
        public IActionResult GetCustomerById(long id )
        {
            return Ok(_customers.FirstOrDefault(e => e.Id == id));
        }


        [HttpPut]
        [Route("customer/{id}")]
        public IActionResult UpdateCustomer(long id, [FromBody] CustomerEntity customerModel)
        {
            if (customerModel == null)
            {
                return BadRequest();
            }

            var customer = _customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            customer.Id = customerModel.Id;
            customer.car = customerModel.car;
            customer.Email = customerModel.Email;
            customer.LastName = customerModel.LastName; 
            customer.FirstName = customerModel.FirstName; 
            return Ok(customer);
        }
        [HttpPut]
        [Route("customer/{id}")]
        public IActionResult UpdateCustomerCar(long id, [FromBody] CarEntity carModel)
        {
            if (carModel == null)
            {
                return BadRequest();
            }

            var customer = _customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            customer.car = carModel; 

            return Ok(customer);
        }


    }
}
