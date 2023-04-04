
using System.ComponentModel.DataAnnotations;

namespace Core_Demo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı şifrenizi giriniz")]
        public string password { get; set; }

    }
}
