namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
    public class Sala
    {
        public int SalaId { get; set; }
        public string NombreSala { get; set; }
        public int Nivel { get; set; }
        public bool Estado { get; set; }
        public string Correcta { get; set; }

        public Sala(int salaId, string nombreSala, int nivel, bool estado, string correcta)
        {
            SalaId = salaId;
            NombreSala = nombreSala;
            Nivel = nivel;
            Estado = estado;
            Correcta = correcta;
        }
        public Sala()
        {
        }
    }
