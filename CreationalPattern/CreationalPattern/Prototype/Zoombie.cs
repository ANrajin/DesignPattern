using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Prototype
{
    public class Zoombie:ICloneable
    {
        public string? Look { get; set; }
        public double Strength { get; set; }
        public double Health { get; set; }
        public double Speed { get; set; }

        //microsoft built in
        public object Clone()
        {
            return (Zoombie)Copy();
        }

        public Zoombie Copy()
        {
            return new Zoombie
            {
                Look = Look,
                Strength = Strength,
                Health = Health,
                Speed = Speed
            };
        }
    }
}
