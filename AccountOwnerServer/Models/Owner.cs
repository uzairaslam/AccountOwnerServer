using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer.Models
{
    public class Owner
    {
        public Guid OwnerId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Length of Name should be between 3 and 60")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Length of Address should be between 3 and 100")]
        public string Address { get; set; }
    }
}
