namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
    public class Partida
    {
        public int PartidaId { get; set; }
        public DateTime FechaInicioPartida { get; set; }
        public bool Estado { get; set; }
        public string NombreJugador { get; set; }
        public Partida(int partidaId, DateTime fechaInicioPartida, bool estado, string nombreJugador)
        {
            PartidaId = partidaId;
            FechaInicioPartida = fechaInicioPartida;
            Estado = estado;
            NombreJugador = nombreJugador;
        }
    }
