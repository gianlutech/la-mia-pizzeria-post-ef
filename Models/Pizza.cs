﻿using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Il nome è obbligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La descrizione è obbligatoria")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Il prezzo deve essere maggiore di 6 euro")]
        public double Price { get; set; }
        public string? Photo { get; set; }

        public Pizza(int id,string Nome, string Descizione, double Prezzo, string Foto)
        {
            this.Id = id;
            this.Name = Nome;
            this.Description = Descizione;
            this.Price = Prezzo;
            this.Photo = Foto;
        }

        public Pizza()
        { }
    }


}
