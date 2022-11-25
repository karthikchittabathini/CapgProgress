using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FootballProject.Models
{
    public class FootBallLeague
    {
        [Key]
        public int MatchId { get; set; }

        [Required]
        [DisplayName("Team 1 Name")]
        public string TeamName1 { get; set; }

        [Required]
        [DisplayName("Team 2 Name")]
        public string TeamName2 { get; set; }

        [Required(ErrorMessage ="Status has to either Win or Draw")]
        public string Status { get; set; }

        [DisplayName("Winning Team")]
        public string? WinningTeam { get; set; }

        [Required]
        public int Points { get; set; }

    }
}
