using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public class Tablero : TableroBase
    {
       public override void OnDraw()
        {
            base.OnDraw();
            Console.SetCursorPosition(Pelota.Posicion.X, Pelota.Posicion.Y);
            Console.Write(Pelota.Source);

            Pelota.Posicion.X += Pelota.VelocidadX;
            Pelota.Posicion.Y += Pelota.VelocidadY;

            if (Pelota.Posicion.X == Ancho)
            {
                if (JugadorDos.Posicion.Y != Pelota.Posicion.Y)
                {
                    Jugador.Score++; 
                }

                Pelota.VelocidadX = -1;
            }

            if (Pelota.Posicion.Y == Alto)
                Pelota.VelocidadY = -1;

            if (Pelota.Posicion.X == 0)
            {
                if (Jugador.Posicion.Y != Pelota.Posicion.Y)
                {
                    JugadorDos.Score++;
                }

                Pelota.VelocidadX = 1;
                
            }

            if (Pelota.Posicion.Y == 0)
                Pelota.VelocidadY = 1;

            Console.SetCursorPosition(Jugador.Posicion.X,Jugador.Posicion.Y);
            Console.Write(Jugador.Source);
            Console.SetCursorPosition(JugadorDos.Posicion.X, JugadorDos.Posicion.Y);
            Console.Write(JugadorDos.Source);


            Console.SetCursorPosition(0, Alto + 5);
            Console.WriteLine($"Jugador Uno {Jugador.Score}");
            Console.WriteLine($"Jugador Dos {JugadorDos.Score}");

        }


    }
}
