using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }


        [StringLength(45, MinimumLength = 3, ErrorMessage = "Length of Account Type should be between 3 and 45")]
        public string AccountType { get; set; }
    }
}
