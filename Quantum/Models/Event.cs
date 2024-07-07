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

        [Required(ErrorMessage ="Please fill event name !")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Please set event date & time !")]
        public DateTime Date { get; set; }
        
    }
}
