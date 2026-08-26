namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
    public class Partida
    {
        public int PartidaId { get; set; }
        public bool Estado { get; set; }
        public int IdJugador { get; set; }
        public double Progreso { get; set; }
        public int Vidas  { get; set; }
        public Partida(int partidaId, bool estado, string nombreJugador, int idJugador, double progreso, int vidas)
        {
            PartidaId = partidaId;
            Estado = estado;
            NombreJugador = nombreJugador;
            IdJugador = idJugador;
            Progreso = progreso;
            Vidas = vidas;
        }
    }
