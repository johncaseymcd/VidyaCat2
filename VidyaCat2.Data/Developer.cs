using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat2.Data
{
    public enum Region
    {
        North_America = 1,
        Asia,
        Europe,
        South_America,
        Africa,
        Australia,
        Unknown
    }

    public class Developer
    {
        [Key]
        public int DeveloperID { get; set; }

        [Required]
        [Display(Name = "Developer")]
        public string DeveloperName { get; set; }
        public Region Region { get; set; }
        public bool IsMajor { get; set; }
        public bool IsActive { get; set; }
        public string Type
        {
            get
            {
                if (IsMajor) return "Major";
                return "Indie";
            }
        }

        public string Status
        {
            get
            {
                if (!IsActive) return "Defunct";
                return "Active";
            }
        }

        [Display(Name = "# of Games")]
        public int GamesDeveloped { get; set; }
    }
}
