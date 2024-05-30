using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quantum.Models
{
    [Table("Events", Schema ="dbo")]
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public Guid evntGUID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } 
        public DateTime Date { get; set; }
        
    }
}
