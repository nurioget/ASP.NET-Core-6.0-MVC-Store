using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class LoginModel
    {
        private string? _returunurl;


        [Required(ErrorMessage ="Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public string ReturnUrl 
        {
            get
            {
                if (_returunurl is null)
                    return "/";
                else
                    return _returunurl;
            }
            set
            {
                _returunurl = value;
            }
        }

    }
}
