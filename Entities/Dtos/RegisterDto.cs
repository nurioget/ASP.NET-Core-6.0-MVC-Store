using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "UsereName is Required")]
        public String? UserName { get; init; }

        [Required(ErrorMessage = "Email is Required")]
        public String? Email { get; init; }

        [Required(ErrorMessage = "Password is Required")]
        public String? Password { get; init; }

    }
}
