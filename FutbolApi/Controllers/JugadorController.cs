using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FutbolApi.Models;
using FutbolApi.Context;

namespace FutbolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        public readonly FutbolContext  _context;

        public JugadorController(FutbolContext context) {
            _context = context; 
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult GetAll()
        {
            List<Jugador> lista = new List<Jugador>();

            try {
                lista = _context.Jugadors.ToList(); 
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", Response = lista});
            }catch(Exception ex) {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = lista });
            }
        }
    }
}
