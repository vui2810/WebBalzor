using System.ComponentModel.DataAnnotations;

namespace BaiThucTap.Models
{
    public class LoaiSanPham
    {
        [Key]
        [Required(ErrorMessage = "Mã loại sản phẩm không được rỗng.")]
        public string Ma_LSP { get; set; }  

        [Required(ErrorMessage = "Tên loại sản phẩm không được rỗng.")]
        public string Ten_LSP { get; set; }

        public string Ghi_Chu { get; set; }
    }
    }
