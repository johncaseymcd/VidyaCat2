using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat2.Data
{
    public enum Brand
    {
        Atari = 1,
        Coleco,
        Magnavox,
        Microsoft,
        NEC,
        Nintendo,
        Panasonic,
        PC,
        Phillips,
        Sega,
        SNK,
        Sony,
        Other
    }

    public class Platform
    {
        [Key]
        public int PlatformID { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        [Display(Name = "Platform")]
        public string PlatformName { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "# of Games")]
        public int GamesOnPlatform { get; set; }

       public bool IsCurrent
        {
            get
            {
                return (DateTime.Today.Year - this.ReleaseDate.Year <= 15);
            }
        }

        public string Status
        {
            get
            {
                if (!IsCurrent) return "Retro";
                return "Current";
            }
        }
    }
}
