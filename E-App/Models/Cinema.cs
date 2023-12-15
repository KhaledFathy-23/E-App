﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_App.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? Logo { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }

        
    }
}
