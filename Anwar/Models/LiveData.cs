using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anwar.Models
{
    public class LiveData
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AutoIncrementID { get; set; }
        public int userId { get; set; }

        public int id { get; set; }

       public  string title { get; set; }
        public string body { get; set; }





    }
}
