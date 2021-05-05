using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaCat2.Data
{
    public enum Genre
    {
        Action = 1,
        Adventure,
        Casual,
        Fighter,
        Horror,
        Narrative,
        Platformer,
        Puzzle,
        Racing,
        RPG,
        Shooter,
        Simulator,
        Sports,
        Strategy
    }

    public enum Subgenre
    {
        [Display(Name = "2D")]
        TwoD = 1,
        [Display(Name = "3D")]
        ThreeD,
        [Display(Name = "8-Bit")]
        Eight_Bit,
        [Display(Name = "16-Bit")]
        Sixteen_Bit,
        Art,
        Baseball,
        Basketball,
        [Display(Name = "Battle Royale")]
        Battle_Royale,
        [Display(Name = "Beat 'Em 'Up")]
        Beat_Em_Up,
        Competitive,
        Fantasy,
        [Display(Name = "First Person")]
        First_Person,
        Fitness,
        Football,
        Golf,
        Hockey,
        Indie,
        JRPG,
        Metroidvania,
        MMO,
        Multiplayer,
        [Display(Name = "Open World")]
        Open_World,
        Other,
        [Display(Name = "Post Apocalyptic")]
        Post_Apocalyptic,
        [Display(Name = "Real Time")]
        Real_Time,
        Roguelike,
        Sandbox,
        [Display(Name = "Third Person")]
        Third_Person,
        [Display(Name = "Top Down")]
        Top_Down,
        [Display(Name = "Turn Based")]
        Turn_Based,
        [Display(Name = "Visual Novel")]
        Visual_Novel,
        [Display(Name = "Walking Simulator")]
        Walking_Simulator
    }

    public enum Rating
    {
        EC = 1,
        E,
        KA,
        [Display(Name = "E10")]
        ETen,
        T,
        M,
        AO,
        [Display(Name = "Not Rated")]
        NR
    }

    public class Game
    {
        [Key]
        public int GameID { get; set; }
        [Required]
        public string GameTitle { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public Subgenre FirstSubgenre { get; set; }
        public Subgenre SecondSubgenre { get; set; }
        public Subgenre ThirdSubgenre { get; set; }
        
        [Required]
        public Rating Rating { get; set; }

        [ForeignKey(nameof(Platform))]
        public int PlatformID { get; set; }
        public virtual Platform Platform { get; set; }

        [ForeignKey(nameof(Developer))]
        public int DeveloperID { get; set; }
        public virtual Developer Developer { get; set; }
    }
}
