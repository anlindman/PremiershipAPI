using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremiershipAPI.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? TeamName { get; set; }
    }
}
