using System.ComponentModel.DataAnnotations;

namespace Intenr.Models
{
    public class NhaCungCap
    {
        [Key]  
        public int Ma_NCC { get; set; }
        [Required(ErrorMessage = "Tên nhà cung cấp không được rỗng.")]
        public string Ten_NCC { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
