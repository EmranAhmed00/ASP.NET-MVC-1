using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TomasosPizzeria.ViewModels
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Gatuadress { get; set; }

        [Required(ErrorMessage = "PostalCode is required")]
        public string Postnr { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string Postort { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telephone is required")]
        public string Telefon { get; set; }

        [Required(ErrorMessage ="UserName is required")]
        [StringLength(20, ErrorMessage ="UserName can be maxumum 20 letters")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "UserName can contain letters and numbers only")]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Losenord { get; set; }

    }
}
