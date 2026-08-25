namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
public class Sala
{
    public int SalaId { get; set; }
    public string NombreSala { get; set; }
    public bool Estado { get; set; }
    public string Respuesta { get; set; }
    public bool Correcta { get; set; }

    public Sala(int salaId, string nombreSala, bool estado, string respuesta, bool correcta)
    {
        SalaId = salaId;
        NombreSala = nombreSala;
        Estado = estado;
        Respuesta = respuesta;
        Correcta = correcta;
    }
} 