//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kpdl1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DT_DangKyNhapKhau
    {
        public DT_DangKyNhapKhau()
        {
            this.DT_HoSoKiemNghiem = new HashSet<DT_HoSoKiemNghiem>();
        }
    
        public long ID { get; set; }
        public Nullable<long> NSWPDFID { get; set; }
        public long NgayLap { get; set; }
        public long STTDangKy { get; set; }
        public Nullable<long> PhuongThucKiemTraID { get; set; }
        public Nullable<long> NgayPhuongThucKiemTra { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChiKhachHang { get; set; }
        public string DienThoaiKhachHang { get; set; }
        public string FaxKhachHang { get; set; }
        public string EmailKhachHang { get; set; }
        public Nullable<long> KhachHangID { get; set; }
        public string SoHopDong { get; set; }
        public Nullable<long> NgayHopDong { get; set; }
        public string PhuLuc { get; set; }
        public string SoHoaDon { get; set; }
        public Nullable<long> NgayHoaDon { get; set; }
        public Nullable<long> BenDenID { get; set; }
        public string TenXuatKhau { get; set; }
        public string DiaChiXuatKhau { get; set; }
        public string DienThoaiXuatKhau { get; set; }
        public string FaxXuatKhau { get; set; }
        public string EmailXuatKhau { get; set; }
        public string BenDiXuatKhau { get; set; }
        public string ThuongNhanCTN { get; set; }
        public string DiaChiThuongNhanCTN { get; set; }
        public string DienThoaiThuongNhanCTN { get; set; }
        public string FaxThuongNhanCTN { get; set; }
        public string EmailThuongNhanCTN { get; set; }
        public string ThuongNhanCTN1 { get; set; }
        public string TenThucPham { get; set; }
        public Nullable<long> PhanLoaiThucPhamID { get; set; }
        public string MoTa { get; set; }
        public string KyHieuMa { get; set; }
        public Nullable<long> QuocGiaID { get; set; }
        public string XuatXu { get; set; }
        public Nullable<double> SoLuong1 { get; set; }
        public string DonViTinhSoLuong1 { get; set; }
        public string GhiChuSoLuong { get; set; }
        public Nullable<long> SoLuong2 { get; set; }
        public string DonViTinhSoLuong2 { get; set; }
        public Nullable<long> SoLuong3 { get; set; }
        public string DonViTinhSoLuong3 { get; set; }
        public Nullable<double> KhoiLuong1 { get; set; }
        public string DonViTinhKhoiLuong1 { get; set; }
        public string GhiChuKhoiLuong { get; set; }
        public Nullable<long> KhoiLuong2 { get; set; }
        public string DonViTinhKhoiLuong2 { get; set; }
        public Nullable<long> KhoiLuong3 { get; set; }
        public string DonViTinhKhoiLuong3 { get; set; }
        public Nullable<short> SoMucHang { get; set; }
        public Nullable<double> GiaTri1 { get; set; }
        public string MaTienTe1 { get; set; }
        public Nullable<double> GiaTri2 { get; set; }
        public string MaTienTe2 { get; set; }
        public Nullable<double> GiaTri3 { get; set; }
        public string MaTienTe3 { get; set; }
        public string GiaTriKhac { get; set; }
        public string SoVanDon { get; set; }
        public Nullable<long> NgayVanDon { get; set; }
        public string SoToKhai { get; set; }
        public Nullable<long> NgayToKhai { get; set; }
        public Nullable<bool> DatYeuCau { get; set; }
        public string GhiChu { get; set; }
        public string SoHanhChinh { get; set; }
        public Nullable<long> NgayHanhChinh { get; set; }
        public string NguoiKyHanhChinh { get; set; }
        public string GhiChuHanhChinh { get; set; }
        public Nullable<bool> KhoaSoHanhChinh { get; set; }
        public string SoXacNhan { get; set; }
        public Nullable<long> NgayXacNhan { get; set; }
        public string NguoiKyXacNhan { get; set; }
        public string GhiChuXacNhan { get; set; }
        public Nullable<long> NgayNhapYeuCauLayMau { get; set; }
        public string SoDienThoaiLayMau { get; set; }
        public string NguoiLienHeLayMau { get; set; }
        public string DiaDiemLayMau { get; set; }
        public string GhiChuLayMau { get; set; }
        public Nullable<long> KiemTraTuNgay { get; set; }
        public Nullable<long> KiemTraDenNgay { get; set; }
        public Nullable<long> NgayTra { get; set; }
        public string NoiDungTra { get; set; }
        public long NgayTao { get; set; }
        public string UserTao { get; set; }
        public Nullable<long> NgaySua { get; set; }
        public string UserSua { get; set; }
        public Nullable<bool> KhoaHanhChinh { get; set; }
        public Nullable<bool> KhoaXacNhan { get; set; }
    
        public virtual ICollection<DT_HoSoKiemNghiem> DT_HoSoKiemNghiem { get; set; }
    }
}
