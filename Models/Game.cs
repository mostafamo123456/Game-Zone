using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameZone.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } =string.Empty;
        [MaxLength(500)]
        public string Cover { get; set; } =string.Empty;
        public int CatogoryId { get; set; }
        public  Catogory Catogory { get; set; } = default!;

        public  List<GameDevice> Devices  { get; set; } = new List<GameDevice>();
    }
}
