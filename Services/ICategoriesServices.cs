using GameZone.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
    public interface ICategoriesServices
    {
        List<SelectListItem> GetSelectList();
    }
}
