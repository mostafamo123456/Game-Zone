using GameZone.Models;
using GameZone.ViewModel;

namespace GameZone.Services
{
    public interface IGamesService
    {
        List<Game> GetAll();
        Task Create(CreateGameFormVM model);
         
    }
}
