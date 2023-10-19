using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EtecBookAPI.DataTransferObjects;

    public class LoginDto
    {
        [Required]
        public string Email { get; set; }        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
