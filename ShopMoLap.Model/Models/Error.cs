using System;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> eeeaea354ee59b8bc5e425cb7360b774188283e8

namespace ShopMoLap.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int ID { get; set; }
<<<<<<< HEAD

=======
>>>>>>> eeeaea354ee59b8bc5e425cb7360b774188283e8
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime CreatedDate { get; set; }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> eeeaea354ee59b8bc5e425cb7360b774188283e8
