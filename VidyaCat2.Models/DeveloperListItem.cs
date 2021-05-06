using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class DeveloperListItem
    {
        [Key]
        public int DeveloperID { get; set; }
        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }
        public Region Region { get; set; }
        public string RegionName
        {
            get
            {
                return Region.ToString().Replace('_', ' ');
            }
        }
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
    }
}
