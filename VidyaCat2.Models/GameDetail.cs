using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;

namespace VidyaCat2.Models
{
    public class GameDetail
    {
        [Key]
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Subgenre 1")]
        public Subgenre FirstSubgenre { get; set; }
        public string FirstSubName
        {
            get
            {
                return GetSubgenreName(FirstSubgenre);
            }
        }

        [Display(Name = "Subgenre 2")]
        public Subgenre SecondSubgenre { get; set; }
        public string SecondSubName
        {
            get
            {
                return GetSubgenreName(SecondSubgenre);
            }

        }

        [Display(Name = "Subgenre 3")]
        public Subgenre ThirdSubgenre { get; set; }
        public string ThirdSubName
        {
            get
            {
                return GetSubgenreName(ThirdSubgenre);
            }
        }
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

        [Display(Name = "Platform")]
        public int PlatformID { get; set; }
        public Platform Platform { get; set; }

        [Display(Name = "Developer")]
        public int DeveloperID { get; set; }
        public Developer Developer { get; set; }

        private string GetSubgenreName(Subgenre sub)
        {
            switch (sub)
            {
                case Subgenre.TwoD:
                    return "2D";
                case Subgenre.ThreeD:
                    return "3D";
                case Subgenre.Eight_Bit:
                    return "8-Bit";
                case Subgenre.Sixteen_Bit:
                    return "16-Bit";
                default:
                    return sub.ToString().Replace('_', ' ');
            }
        }
    }
}
