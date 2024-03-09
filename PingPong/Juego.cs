using PingPong.Consola;
using PingPong.Core;

namespace PingPong
{
    public class Juego
    {
        private static Juego? instance;
        public static Juego Instancia
        {
            get {
                instance ??= new Juego();
                return instance; 
            }
            private set { }

        }
        
        public GameAdapter GameAdapter { get; set; }

        private Juego() {}  
        
        public void StartGame()
        {
            GameAdapter.InitGame();
        }
    }
}
