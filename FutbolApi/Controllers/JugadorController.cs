using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FutbolApi.Models;
using FutbolApi.Context;
using FutbolApi.Repositories;

namespace FutbolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        public readonly IJugadorRepository _jugadorRepository;

        public JugadorController(IJugadorRepository jugador)
        {
            _jugadorRepository = jugador;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> GetJugadores()
        {
            return Ok(await _jugadorRepository.GetAll());
        }

        [HttpGet]
        [Route("Obtener/{id:int}")]
        public async Task<IActionResult> GetJugador(int id)
        {
            Jugador jugadorEncontrado = await _jugadorRepository.GetById(id);

            if (jugadorEncontrado == null) return BadRequest("Jugador No Encontrado");

            try
            {
                return Ok(jugadorEncontrado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Ingresar")]
        public async Task<IActionResult> CreateJugador([FromBody] Jugador jugador)
        {
            if (jugador == null) return BadRequest("No hay Datos");
            if (!ModelState.IsValid) return BadRequest("El formato es incorrecto");

            var created = await _jugadorRepository.Insert(jugador);
            return Ok(new { message = "Jugador Ingresado" });
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<IActionResult> Update([FromBody] Jugador jugador)
        {
            if(jugador == null) return BadRequest("No hay Datos");
            if (!ModelState.IsValid) return BadRequest("El formato es incorrecto");

            try
            {
                await _jugadorRepository.Update(jugador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Ok("Jugador Modificado");
        }

        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _jugadorRepository.DeleteById(id);
            return NoContent();
        }

    }
}
