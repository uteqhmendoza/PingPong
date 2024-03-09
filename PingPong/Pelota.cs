using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Pelota
    {
        public string Source { get; set; } = "°";
        public Posicion Posicion { get; set; }  = new Posicion();
        public int VelocidadX { get; set; } = 1;
        public int VelocidadY { get; set; } = 1;
    }
}
