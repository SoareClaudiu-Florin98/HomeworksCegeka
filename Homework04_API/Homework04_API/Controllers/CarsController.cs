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
    public class CarsController : ControllerBase
    {
        public  static List<CarEntity> _cars = new List<CarEntity>() ; 
        public CarsController()
        {
            _cars = new List<CarEntity>()
            {
                new CarEntity()
                {
                    Model = "Golf",
                    HorsePower = 140 ,
                    Manufacturer = "Volkswagen",
                    Transmission=  Transmission.Manual,
                    ManufactureDate = new DateTime(2005,11,20) 
                },
                new CarEntity()
                {
                    Model = "Model S ",
                    HorsePower = 440 ,
                    Manufacturer = "Tesla",
                    Transmission=  Transmission.Automatic,
                    ManufactureDate = new DateTime(2020,11,20)
                }

            }; 
        }
        [HttpGet]
        [Route("cars")]
        public IActionResult GetAllCars()
        {
            return Ok(_cars); 

        }

        [HttpGet]
        [Route("cars/{model}")]
        public IActionResult GetCarByModel( string model)
        {
            return Ok(_cars.FirstOrDefault(e => e.Model == model)); 

        }


        [HttpPost]
        [Route("cars")]
        public IActionResult AddNewCar([FromBody] CarEntity carModel)
        {
            if(carModel == null)
            {
                return BadRequest(); 
            }
            if (carModel.HorsePower < 30)
            {
                return BadRequest();
            }
            if (carModel.ManufactureDate < new DateTime(1700,1,1))
            {
                return BadRequest();
            }
            if (carModel.Manufacturer == null)
            {
                return BadRequest();
            }
            _cars.Add(carModel); 
            return Ok(carModel); 

        }
        [HttpPut]
        [Route("cars/{model}")]
        public IActionResult UpdateCarByModel(string model , [FromBody] CarEntity carModel)
        {
            if(carModel == null)
            {
                return BadRequest(); 
            }

            var car = _cars.FirstOrDefault(x => x.Model == model); 
            if(car == null)
            {
                return NotFound(); 
            }            
            car.Manufacturer = carModel.Manufacturer;
            car.ManufactureDate = DateTime.Parse(carModel.ManufactureDate.ToString());
            car.HorsePower = carModel.HorsePower;
            car.Transmission = carModel.Transmission;            

            return Ok(car); 
        }
        [HttpDelete]
        [Route("car/{model}")]
        public IActionResult RemoveCar(string model)
        {
            if(model != null)
            {
                return BadRequest(); 
            }
            var car = _cars.FirstOrDefault(x => x.Model == model); 
            if(car == null)
            {
                return BadRequest(); 
            }
            _cars.Remove(car);
            return Ok(); 
        }

    }
}
