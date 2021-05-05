using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class GameEdit
    {
        [Key]
        public int GameID { get; set; }
        public string GameTitle { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Subgenre 1")]
        public Subgenre FirstSubgenre { get; set; }

        [Display(Name = "Subgenre 2")]
        public Subgenre SecondSubgenre { get; set; }

        [Display(Name = "Subgenre 3")]
        public Subgenre ThirdSubgenre { get; set; }
        public Rating Rating { get; set; }
        public int PlatformID { get; set; }
        public int DeveloperID { get; set; }
    }
}
