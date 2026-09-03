using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;

namespace TP06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult Registro(string Nombre, string Apellido, string Email, string Usuario, string Clave, int id)
    {
        BD bd = new BD();
        Jugador J = new Jugador(id, Usuario, Email, Clave, Nombre, Apellido);
        if (bd.buscarPorNombreUsuario(J.Usuario) == null)
        {
            bd.agregarJugador(J);
            return RedirectToAction("InicioSesion", "Home");
        }
        else
        {
            ViewBag.error = "El nombre de usuario ya existe.";
            return RedirectToAction("Registro", "Home");
        }
    
    }
    [HttpPost]
public IActionResult InicioSesion(string Usuario, string Clave)
{
    BD bd = new BD();
    Jugador usuarioEncontrado = bd.encontrarUsuario(Usuario, Clave);

    if (usuarioEncontrado == null)
    {
        ViewBag.Error = "Usuario o contraseña incorrectos.";
        return View();
    }
    HttpContext.Session.SetString("usuario", usuarioEncontrado.Usuario);
    HttpContext.Session.SetString("nombre", usuarioEncontrado.Nombre);
    HttpContext.Session.SetString("apellido", usuarioEncontrado.Apellido);
    HttpContext.Session.SetString("progreso", usuarioEncontrado.Progreso.ToString());
   
    return RedirectToAction("PaginaPrincipal", "Home");
}
    public IActionResult PaginaPrincipal()
    {
        BD bd = new BD();
        if (string.IsNullOrEmpty(HttpContext.Session.GetString("usuario")))
        {
            
            return RedirectToAction("InicioSesion", "Home");
        }
        ViewBag.Usuario = HttpContext.Session.GetString("usuario");
        ViewBag.Nombre = HttpContext.Session.GetString("nombre");
        ViewBag.Apellido = HttpContext.Session.GetString("apellido");
        ViewBag.Progreso = HttpContext.Session.GetString("progreso");
        ViewBag.Salas = bd.ObtenerSalas();
        return View();
    }
    public IActionResult ListadoSalas ()
    {
        BD bd = new BD();
1       ViewBag.Salas = bd.ObtenerSalas();
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
