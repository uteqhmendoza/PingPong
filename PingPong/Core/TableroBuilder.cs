using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public class TableroBuilder
    {
        private TableroBase tablero;

        private Pelota pelota;
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        public TableroBuilder AddPelota(Pelota pelota)
        {
            this.pelota = pelota;
            return this;
        }

        public TableroBuilder AddJugador(Jugador jugador)
        {
            if (jugadorUno ==  null)
                this.jugadorUno = jugador;
            else
                this.jugadorDos = jugador;

            return this;
        }

        public ITablero Build()
        {
            FactoryTablero factory = new();

            if (jugadorDos == null)
            {
                tablero = factory.CreateInstance<TableroSolo>();
            }
            else
            {
                tablero = factory.CreateInstance<Tablero>();
                tablero.JugadorDos = jugadorDos;
                tablero.JugadorDos.Posicion.X = tablero.Ancho - 1;
                tablero.JugadorDos.Posicion.Y = tablero.Alto / 2;
            }

            tablero.Pelota = pelota;
            tablero.Jugador = jugadorUno;
            tablero.Jugador.Posicion.X = 1;
            tablero.Jugador.Posicion.Y = tablero.Alto /  2;
            return tablero;
        }

    }
}
