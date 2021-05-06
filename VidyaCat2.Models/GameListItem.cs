using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class GameListItem
    {
        [Key]
        public int GameID { get; set; }
        [Display(Name = "Game Title")]
        public string GameTitle { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Rating Rating { get; set; }
        public string RatingName
        {
            get
            {
                if (Rating == Rating.ETen)
                {
                    return "E10";
                }
                else if (Rating == Rating.NR)
                {
                    return "Not Rated";
                }
                else
                {
                    return Rating.ToString();
                }
            }
        }

        public int DeveloperID { get; set; }
        [Display(Name = "Developer")]
        public Developer Developer { get; set; }

        public int PlatformID { get; set; }
        [Display(Name = "Platform")]
        public Platform Platform { get; set; }
    }
}
