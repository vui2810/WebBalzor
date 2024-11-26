using System.ComponentModel.DataAnnotations;

namespace WebBalzor.Models
{
    public class DM_Kho_User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mã đăng nhập không được rỗng.")]
        public string Ma_Dang_Nhap { get; set; }
        [Required(ErrorMessage = "Mã kho id không được rỗng.")]
        public int Kho_ID { get; set; }
        public string Role { get; set; }
    }
}
