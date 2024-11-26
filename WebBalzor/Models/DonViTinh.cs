using System.ComponentModel.DataAnnotations;

namespace Intenr.Models
{
    public class DonViTinh
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên đơn Vị tính không được để trống.")]
        public string Ten_Don_Vi_Tinh { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
