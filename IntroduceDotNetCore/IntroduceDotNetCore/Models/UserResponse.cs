using System.ComponentModel.DataAnnotations;

namespace IntroduceDotNetCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Adınızı giriniz!")]
        [MinLength(3, ErrorMessage ="En az üç harf girmelisiniz")]
        public string Name { get; set; }
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Eposta adresi hatalı formatta!")]
        public string Email { get; set; }
        public bool IsApproved { get; set; }

    }
}
