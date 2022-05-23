﻿using System.ComponentModel.DataAnnotations;

namespace OutfitKing.Models
{
    public class GebruikerVM
    {
        /// <summary>
        /// Datatype + "?" = een waarde kan null zijn (handig bij bijv gebruik van database)
        /// -
        /// Models bevatten data en businesslogic
        /// </summary>

        public int ID { get; set; }
        [Required]
        public string? Alias { get; set; }
        [Required]
        public string? Wachtwoord { get; set; }
        [Required]
        public string? Gerbuikersnaam { get; set; }
        public bool Retry { get; set; }

        //public List<Outfit> Outfits { get; set; } = new List<Outfit>();
        //public List<Onderdeel> Onderdelen { get; set; } = new List<Onderdeel>();
      
        public GebruikerVM(int id, string wachtwoord, string gerbuikersnaam)
        {
            this.Wachtwoord = wachtwoord;
            this.Gerbuikersnaam = gerbuikersnaam;
            this.ID = id;
        }
        
        public GebruikerVM()
        {
         
        }
    }
}
