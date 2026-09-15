namespace TP06.Models;

using Microsoft.Data.SqlClient;
using Dapper;
public class BD
{
    private string conexion = @"Server=LocalHost;DataBase=TP06; Integrated Security=True; TrustServerCertificate=True;";
    public void agregarJugador(Jugador j)
    {
        string query = "INSERT INTO Jugador (Nombre,Apellido,Usuario,Clave,Email,Progreso) VALUES (@Nombre,@Apellido,@Usuario,@Clave,@Email,@Progreso)";
        using (SqlConnection connection = new SqlConnection(conexion))
        {
            connection.Execute(query, new { Nombre = j.Nombre, Apellido = j.Apellido, Usuario = j.Usuario, Clave = j.Clave, Email = j.Email, Progreso = j.Progreso });
        }
    }
    public Sala ObtenerSala(int id)
    {
        string query = "SELECT * FROM Sala WHERE SalaId = @id";

        using (SqlConnection connection = new SqlConnection(conexion))
        {
            return connection.QueryFirstOrDefault<Sala>( query,new { id });
        }
    }
    public List<Sala> ObtenerSalas()
{
    string query = "SELECT * FROM Sala ORDER BY Nivel";

    using (SqlConnection connection = new SqlConnection(conexion))
    {
        return connection.Query<Sala>(query).ToList();
    }
}

   
     public Jugador encontrarUsuario(string Usuario, string Clave)
    {
        string query = "SELECT IdJugador, Nombre, Apellido, Usuario, Clave, Email, Progreso FROM Jugador WHERE Usuario = @Usuario AND clave = @Clave";
        using (SqlConnection connection = new SqlConnection(conexion))
        {
            return connection.QueryFirstOrDefault<Jugador>(query, new { Usuario, Clave });
        }
    }

    public Jugador buscarPorNombreUsuario(string Usuario)
    {
        string query = "SELECT IdJugador, Nombre, Apellido, Usuario, Clave, Email, Progreso FROM Jugador WHERE usuario = @Usuario";
        using (SqlConnection connection = new SqlConnection(conexion))
        {
            return connection.QueryFirstOrDefault<Jugador>(query, new { Usuario });
        }
    }
  public void actualizarEstado(int id)
{
    string query = "UPDATE Sala SET Estado = 0 WHERE SalaId = @id";

    using (SqlConnection connection = new SqlConnection(conexion))
    {
        connection.Execute(query, new { id });
    }
}

public void actualizarProgreso(string usuario, double progreso)
{
    string query = "UPDATE Jugador SET Progreso = @Progreso WHERE Usuario = @Usuario";

    using (SqlConnection connection = new SqlConnection(conexion))
    {
        connection.Execute(query, new { Usuario = usuario, Progreso = progreso });
    }
}
}