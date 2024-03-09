using PingPong.Consola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Jugador : ICloneable
    {
        public string Source { get; set; } = "|";
        public Posicion Posicion { get; set; } = new Posicion();


        public Command MoveUp { get; set; }

        public Command MoveDown { get; set; }

        public int Score {  get; set; }

        public object Clone()
        {
            return new Jugador();
        }
    }
}
