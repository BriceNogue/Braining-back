using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class UserDTO : _BaseDTO
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Phone_number { get; set; } = string.Empty;
        public string Email_address { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; }
    }
}
