using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class GameCreate
    {
        [Key]
        public int GameID { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Game title cannot be longer than 500 characters. If it is, stop it. Get some help.")]
        [Display(Name = "Game Title")]
        public string GameTitle { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Display(Name = "Subgenre 1")]
        public Subgenre FirstSubgenre { get; set; }

        [Display(Name = "Subgenre 2")]
        public Subgenre SecondSubgenre { get; set; }

        [Display(Name = "Subgenre 3")]
        public Subgenre ThirdSubgenre { get; set; }

        [Required]
        public Rating Rating { get; set; }

        [Required]
        public int DeveloperID { get; set; }
        [Required]
        public int PlatformID { get; set; }
    }
}
