using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Homework04_API.Models
{
    public enum Transmission
    {
        [Description("Automatic")]
        Automatic,
        [Description("Manual")]
        Manual
    }
}
