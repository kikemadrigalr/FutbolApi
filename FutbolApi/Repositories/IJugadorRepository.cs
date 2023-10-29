using FutbolApi.Models;

namespace FutbolApi.Repositories
{
    public interface IJugadorRepository
    {
        Task<IEnumerable<Jugador>> GetAll();

        Task<Jugador> GetById(int id);

        Task<bool> Insert(Jugador jugador);

        Task<bool> Update(Jugador jugador);

        Task<bool> DeleteById(int id);


    }
}
