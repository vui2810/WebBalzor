using System.ComponentModel.DataAnnotations;

namespace WebBalzor.Models
{
    public class DM_Kho
    {
        [Key]
        [Required(ErrorMessage = "Tên khô không được rỗng.")]
        public string Ten_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
