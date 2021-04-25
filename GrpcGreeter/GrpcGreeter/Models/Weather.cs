using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Models
{
    public class Weather
    {
        public string name { get; set; }
        public Coordinates coord { get; set; }
        public Main main { get; set; }


    }

    public class Coordinates
    {
        public double lon { get; set; }
        public double lat { get; set; }

    }

    public class Main
    {
        public double temp { get; set; }
        public double sea_level { get; set; }
    }
}
