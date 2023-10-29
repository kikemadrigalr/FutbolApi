using FutbolApi.Context;
using FutbolApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FutbolApi.Repositories
{
    public class JugadorRepository : IJugadorRepository
    {

        private readonly FutbolContext _context;
       
        public JugadorRepository(FutbolContext contex)
        {
            _context = contex;
        }

        public async Task<IEnumerable<Jugador>> GetAll()
        {
            return await _context.Jugadors.ToListAsync();
        }

        public async Task<Jugador> GetById(int id)
        {
            Jugador jugador = await _context.Jugadors.FindAsync(id);
            return jugador;
        }

        public async Task<bool> Insert(Jugador jugador)
        {
            _context.Jugadors.Add(jugador);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> Update(Jugador jugador)
        {
            _context.Entry(jugador).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> DeleteById(int id)
        {
            var jugadorEncontrado = await _context.Jugadors.FindAsync(id);

            _context.Jugadors.Remove(jugadorEncontrado);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        
    }
}
