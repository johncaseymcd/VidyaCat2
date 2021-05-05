using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class PlatformListItem
    {
        [Key]
        public int PlatformID { get; set; }
        public Brand Brand { get; set; }

        [Display(Name = "Platform Name")]
        public string PlatformName { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

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
