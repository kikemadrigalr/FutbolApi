using FutbolApi.Context;
using FutbolApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FutbolApi.Repositories
{
    //Esta clase se encarga del acceso a los datos, se utiliza Entity Framework para la manipulacion de la BD

    //La clase jugadorRepository implementa la interfaz IJugadorRepository
    //Debe cumpli con el contrato de la interfaz implementando los metodos definidos
    public class JugadorRepository : IJugadorRepository
    {
        //Contexto de la base de datos
        private readonly FutbolContext _context;
       
        //inyeccion en el constructor para manipular los datos desde el contexto de la BD
        public JugadorRepository(FutbolContext contex)
        {
            _context = contex;
        }

        //Obtener el listado de todos los jugadores
        public async Task<IEnumerable<Jugador>> GetAll()
        {
            return await _context.Jugadors.ToListAsync();
        }

        //Obtener un unico jugador por su Id
        public async Task<Jugador> GetById(int id)
        {
            Jugador jugador = await _context.Jugadors.FindAsync(id);
            return jugador;
        }

        //Insertar un nuevo jugador
        public async Task<bool> Insert(Jugador jugador)
        {
            _context.Jugadors.Add(jugador);
            //Devuelve un valor entero 0/1 si el jugador se ingreso correctamente
            var result = await _context.SaveChangesAsync();
            //si resul es mayor a 0 devuelve true confirmando la creacion del jugar
            return result > 0;
        }

        //Modificar un jugador existente
        public async Task<bool> Update(Jugador jugador)
        {
            _context.Entry(jugador).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        //Eliminar un jugador
        public async Task<bool> DeleteById(int id)
        {
            var jugadorEncontrado = await _context.Jugadors.FindAsync(id);

            _context.Jugadors.Remove(jugadorEncontrado);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        
    }
}
