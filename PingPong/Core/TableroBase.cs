using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public abstract class TableroBase : ITablero
    {
        public int Alto { get; set; } = 20;
        public int Ancho { get; set; } = 30;

        public Pelota Pelota { get; set; }
        public Jugador Jugador { get; set; }
        public Jugador JugadorDos { get; set; }

        public virtual void OnDraw()
        {
            for (int i = 0; i < Alto; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                Console.SetCursorPosition(Ancho, i);
                Console.Write("*");
            }

            for (int i = 0; i < Ancho; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                Console.SetCursorPosition(i, Alto);
                Console.Write("*");
            }
        }

        public void MoveUpJugador(Jugador jugador)
        {
                jugador.Posicion.Y--;
                if (jugador.Posicion.Y <= 1)
                   jugador.Posicion.Y = 1;
        }

        public void MoveDownJugador(Jugador jugador)
        {
             jugador.Posicion.Y++;
             if (jugador.Posicion.Y >= Alto)
                 jugador.Posicion.Y = Alto - 1;
            
        }
    }
}
