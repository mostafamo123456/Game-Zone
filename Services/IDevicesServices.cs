using GameZone.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
    public interface IDevicesServices
    {
        List<SelectListItem> GetSelectList();
    }
}
