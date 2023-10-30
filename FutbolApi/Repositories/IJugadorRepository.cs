using FutbolApi.Models;

namespace FutbolApi.Repositories
{
    //Definir los metodos para manipular el API jugadores
    public interface IJugadorRepository
    {
        //Obtener todos los jugadores
        Task<IEnumerable<Jugador>> GetAll();

        //Obtener un jugador por su ID
        Task<Jugador> GetById(int id);

        //Insertar un nuevo jugador
        Task<bool> Insert(Jugador jugador);

        //Modificar un jugador
        Task<bool> Update(Jugador jugador);

        //Eliminar Jugador
        Task<bool> DeleteById(int id);


    }
}
