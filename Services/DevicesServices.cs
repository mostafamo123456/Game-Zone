using GameZone.Data;
using GameZone.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
    public class DevicesServices : IDevicesServices
    {
        private readonly ApplicationDbContext context;
        public DevicesServices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<SelectListItem> GetSelectList()
        {
           return context.Devices.Select(x => new SelectListItem {Value=x.Id.ToString(), Text=x.Name}).ToList();
        }
    }
}
