﻿using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Catogory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public  List<Game>  Games { get; set; } = new List<Game>();

    }
}
