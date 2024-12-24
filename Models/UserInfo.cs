using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{
    public class UserInfo{
        public int id { get; set; }
        
        [Required(ErrorMessage="İsim alanı boş geçilemez!")]
        public string? name { get; set; }
        
        [Required(ErrorMessage = "Telefon alanı boş geçilemez!")]
        public string? phone { get; set; }
        
        [Required(ErrorMessage = "Email alanı boş geçilemez!")]
        [EmailAddress(ErrorMessage ="Geçerli bir email adresi giriniz!")]
        public string? email { get; set; }
        
        [Required(ErrorMessage = "Katılacak mısınız?")]
        public bool? willattend { get; set; }
    }
}