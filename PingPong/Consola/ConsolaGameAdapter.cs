using PingPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Consola
{
    public class ConsolaGameAdapter : GameAdapter
    {
        public ConsolaGameAdapter(ITablero tablero) : base(tablero)
        { 
        
        }
        
        public override void OnPlay()
        {
            Console.CursorVisible = false;

            TableroBase tableroBase = (TableroBase)Tablero;

            tableroBase.Jugador.MoveDown = new Command(key => key.Key == ConsoleKey.UpArrow, tableroBase.MoveUpJugador);
            tableroBase.Jugador.MoveUp = new Command(key => key.Key == ConsoleKey.DownArrow, tableroBase.MoveDownJugador);

            tableroBase.JugadorDos.MoveDown = new Command(key => key.Key == ConsoleKey.W, tableroBase.MoveUpJugador);
            tableroBase.JugadorDos.MoveUp = new Command(key => key.Key == ConsoleKey.A, tableroBase.MoveDownJugador);

            while (isPlay)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo =  Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.P)
                    {
                       OnPause();
                    }

                    if (keyInfo.Key == ConsoleKey.C)
                    {
                        OnStop();
                    }
                    
                    if (tableroBase.Jugador.MoveDown.CanExecute(keyInfo))
                        tableroBase.Jugador.MoveDown.Execute(Tablero.Jugador);
                    
                    if (tableroBase.Jugador.MoveUp.CanExecute(keyInfo))
                        tableroBase.Jugador.MoveUp.Execute(Tablero.Jugador);

                    if (tableroBase.JugadorDos.MoveDown.CanExecute(keyInfo))
                        tableroBase.JugadorDos.MoveDown.Execute(tableroBase.JugadorDos);
                   
                    if (tableroBase.JugadorDos.MoveUp.CanExecute(keyInfo))
                        tableroBase.JugadorDos.MoveUp.Execute(tableroBase.JugadorDos);

                }

                if (isPause)
                    continue;

               
                tableroBase.OnDraw();
               

                Thread.Sleep(100);
                Console.Clear();
            }


        }
        
    }
}
