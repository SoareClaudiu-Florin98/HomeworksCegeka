using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Homework04_API.Models
{
    public class CarEntity
    {       
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int HorsePower { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Transmission Transmission { get; set; }
    }
}
