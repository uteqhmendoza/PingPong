using PingPong;
using PingPong.Consola;
using PingPong.Core;


Juego juegoUno = Juego.Instancia;

Jugador jugador = new();
TableroBuilder builder = new TableroBuilder()
.AddPelota(new Pelota())
.AddJugador(jugador)
.AddJugador((Jugador)jugador.Clone());

juegoUno.GameAdapter = new ConsolaGameAdapter(builder.Build());
juegoUno.StartGame();
        
