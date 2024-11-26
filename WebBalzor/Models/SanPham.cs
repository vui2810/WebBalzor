using System.ComponentModel.DataAnnotations;

namespace Intenr.Models
{
    public class SanPham
    {
        [Key]
        [Required(ErrorMessage = "Mã sản phẩm không được rỗng.")]
        public string Ma_San_Pham { get; set; }  // Thay đổi kiểu dữ liệu thành int

        [Required(ErrorMessage = "Tên sản phẩm không được rỗng.")]
        public string Ten_San_Pham { get; set; }
        [Required(ErrorMessage = "Loại  sản phẩm Id không được rỗng.")]
        public string Loai_San_Pham_Id { get; set; }
        [Required(ErrorMessage = "Đơn vị tính Id không được rỗng.")]
        public int Don_Vi_Tinh_ID { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
