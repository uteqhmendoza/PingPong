using PingPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Consola
{
    public abstract class GameAdapter
    {
        protected bool isPlay;
        protected bool isPause;

        public ITablero Tablero { get; }

        public GameAdapter(ITablero tablero)
        {
            Tablero = tablero;
           
        }

        public void InitGame()
        {
            Console.WriteLine("Bienvenido a PingPong");
            Console.WriteLine("Presione cualquier tecla para empezar el juego");
            Console.ReadKey();
            isPlay = true;
            OnPlay();
        }

        public abstract void OnPlay();
        

        public void OnStop()
        {
            isPlay = false;
        }
        

        public void OnPause()
        {
            isPause = !isPause;
        }
        
    }
}
