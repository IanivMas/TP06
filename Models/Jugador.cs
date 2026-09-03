namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;
public class Jugador
{
    public int IdJugador { get; set; }
    public string Usuario { get; set; }
    public string Clave { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public int Vidas { get; set; }
    public double Progreso { get; set; }
    public string Apellido { get; set; }
    public Jugador(int idJugador, string usuario, string email, string clave, string nombre, string apellido)
    {
        IdJugador = idJugador;
        Usuario = usuario;
        Clave = clave;
        Nombre = nombre;
        Email = email;
        Vidas = 3;
        Progreso = 0;
        Apellido = apellido;
    }
      public Jugador()
    {
        
    }
}
