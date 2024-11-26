using System.ComponentModel.DataAnnotations;

namespace WebBalzor.Models
{
    public class NhapKho
    {
        [Key]
        [Required(ErrorMessage = "Số phiếu nhập không được rỗng.")]
        public string So_Phieu_Nhap_Kho { get; set; }
        [Required(ErrorMessage = "Kho không được rỗng.")]
        public int Kho_ID { get; set; }
        [Required(ErrorMessage = "NCC không được rỗng.")]
        public int NCC_ID { get; set; }
        [Required(ErrorMessage = "Ngày nhập kho  không được rỗng.")]
        public DateTime Ngay_Nhap_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
    public class DM_Nhap_Kho_Raw_Data
    {
        public int Nhap_Kho_ID { get; set; }        // ID nhập kho
        public int San_Pham_ID { get; set; }        // ID sản phẩm
        public int SL_Nhap { get; set; }            // Số lượng nhập
        public decimal Don_Gia_Nhap { get; set; }   // Đơn giá nhập
    }
}
