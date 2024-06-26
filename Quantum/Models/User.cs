using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quantum.Models
{

    //*> Maja 

    [Table("Users", Schema = "dbo")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

   

    }



   

}
