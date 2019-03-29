using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TomasosPizzeria.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName is required")]
        [StringLength(20, ErrorMessage = "UserName can be maxumum 20 letters")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "UserName contains letters and numbers only")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}


