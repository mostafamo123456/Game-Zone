using GameZone.Attributes;
using GameZone.Settings;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GameZone.ViewModel
{
    public class CreateGameFormVM
    {
        [MaxLength(250)]
        public string Name { get; set; }
        [Display(Name = "Category")]
        public int CatogoryId { get; set; }

        public List<SelectListItem> Catogories {  get; set; } = new List<SelectListItem>();
        [Display(Name = "Devices")]
        public List<int> SelectedDevices { get; set; }
        public List<SelectListItem> Devices { get; set; } = new List<SelectListItem>();
        [MaxLength(250)]
        public string Description { get; set; }

        [AllowedExtension(FileSettings.AllowExtensions)]
        [MaxFileSize(FileSettings.MaxFileSizeInByte)]
        public IFormFile Cover { get; set; } = default!;

    }
}
