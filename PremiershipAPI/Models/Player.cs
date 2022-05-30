using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremiershipAPI.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? PlayerName { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string? SquadNumber { get; set; }
        public int TeamId { get; set; }
        public int NationId { get; set; }
    }
}
