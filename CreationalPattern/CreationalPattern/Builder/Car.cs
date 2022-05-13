using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder
{
    public class Car
    {
        public string Color  { get; set; }
        public string Wheel { get; set; }
        public object Engine { get; set; }
    }

    public class Engine
    {

    }
}
