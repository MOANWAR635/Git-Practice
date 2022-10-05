using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anwar.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  string ID { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Passwords { get; set; }

        [Required]
        public string  FatherName{ get; set; }

        public string Address { get; set; }

        public string Pincode { get; set; }

    }
}
