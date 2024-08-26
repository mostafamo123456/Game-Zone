using GameZone.Data;
using GameZone.ViewModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ApplicationDbContext context;
        public CategoriesServices(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<SelectListItem> GetSelectList()
        {

            return  context.Categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name }).OrderBy(C => C.Text).ToList();

        }
    }
}
