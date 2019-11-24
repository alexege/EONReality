using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegEON.Models
{
    public class User
    {
        [Display(Name = "No")]
        public int ID { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Reg")]
        [Required]
        public DateTime DateRegistered { get; set; }

        [Display(Name = "Selected Days")]
        [Required]
        public string Days { get; set; }

        [Display(Name = "Add. request")]
        [StringLength(100)]
        public string Requests { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;

    }
}
