using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public interface ITablero
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public Pelota Pelota { get; set; }
        public Jugador Jugador { get; set; }
        public void OnDraw();
    }
}
