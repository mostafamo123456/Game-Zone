using GameZone.Data;
using GameZone.Models;
using GameZone.Services;
using GameZone.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly ICategoriesServices categoriesServices;
        private readonly IDevicesServices devicesServices;
        private readonly IGamesService gamesServices;

        public GamesController(ICategoriesServices categoriesServices, IDevicesServices devicesServices, IGamesService gamesServices)
        {
            this.categoriesServices = categoriesServices;
            this.devicesServices = devicesServices;
            this.gamesServices = gamesServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateGameFormVM vm = new()
            {
                Catogories = categoriesServices.GetSelectList(),
                Devices = devicesServices.GetSelectList(),

            };
            return View(vm);
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameFormVM model)
        {
            if (!ModelState.IsValid)
            {
              model.Catogories=categoriesServices.GetSelectList();
              model.Devices =  devicesServices.GetSelectList();
                return View(model);
            }
            await gamesServices.Create(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
