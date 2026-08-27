namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
    public class Sala
    {
        public int SalaId { get; set; }
        public string NombreSala { get; set; }
        public int Nivel { get; set; }
        public bool Estado { get; set; }
        public int IdJugador { get; set; }
        public bool Correcta { get; set; }

        public Sala(int salaId, string nombreSala,int nivel, bool estado, int idJugador, bool correcta)
        {
            SalaId = salaId;
            NombreSala = nombreSala;
            Nivel = nivel;
            Estado = estado;
            IdJugador = idJugador;
            Correcta = correcta;
        }
    }
