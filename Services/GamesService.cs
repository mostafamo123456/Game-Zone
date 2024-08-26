using GameZone.Data;
using GameZone.Models;
using GameZone.Settings;
using GameZone.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Services
{
    public  class GamesService:IGamesService
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly string imagePath;
        public  GamesService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
            imagePath = $"{webHostEnvironment.WebRootPath}{FileSettings.ImagesPath}";
        }

        public async Task Create(CreateGameFormVM model)
        {
            var CoverName =$"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";
            var path = Path.Combine(imagePath, CoverName);
            using var stream = File.Create(path);
            await model.Cover.CopyToAsync(stream);
            Game game = new()
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CatogoryId,
                Cover = CoverName,
                Devices = model.SelectedDevices.Select(d => new GameDevice { DeviceId = d }).ToList()

            };
            context.Add(game);
            context.SaveChanges();
        }
       public List<Game> GetAll() 
        { 
           List<Game> games = context.Games.Include(g=>g.Catogory).Include(d=>d.Devices).ThenInclude(d=>d.Device).AsNoTracking().ToList();
            return games;
            
        }

    }
}
