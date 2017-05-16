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
    
    public partial class NS_HoSo
    {
        public NS_HoSo()
        {
            this.DM_TaiKhoan = new HashSet<DM_TaiKhoan>();
            this.DT_HoSoKiemNghiem = new HashSet<DT_HoSoKiemNghiem>();
            this.DT_PhieuPhanTichChiTieu = new HashSet<DT_PhieuPhanTichChiTieu>();
        }
    
        public long ID { get; set; }
        public string MaNhanSu { get; set; }
        public string MaLoaiHopDong { get; set; }
        public string SoHoSo { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public byte[] Anh { get; set; }
        public string BiDanh { get; set; }
        public long NgaySinh { get; set; }
        public string DinhDangNgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string QueQuan { get; set; }
        public string MaTinhTrangHonNhan { get; set; }
        public long ToChucDoanTheID { get; set; }
        public long NgayBatDau { get; set; }
        public string SoQuyetDinh { get; set; }
        public string MaNguoiQuyetDinh { get; set; }
        public string SoCMTND { get; set; }
        public Nullable<long> NgayCapCMTND { get; set; }
        public string NoiCapCMTND { get; set; }
        public string MaSoThue { get; set; }
        public string SucKhoe { get; set; }
        public Nullable<double> ChieuCao { get; set; }
        public Nullable<double> CanNang { get; set; }
        public string NhomMau { get; set; }
        public string GhiChu { get; set; }
        public short TrangThai { get; set; }
        public string DienThoai { get; set; }
        public string ThuongTru { get; set; }
        public string HoSo { get; set; }
        public string ChuyenMon { get; set; }
        public bool LaTruongPhong { get; set; }
        public bool LaPhoPhong { get; set; }
        public string NgheNghiepTuyenDung { get; set; }
        public string CoQuanTuyenDung { get; set; }
        public Nullable<long> NgayTuyenDung { get; set; }
        public string CongViecChinh { get; set; }
        public Nullable<long> ImportID { get; set; }
        public Nullable<bool> LaNguoiKyKiemNghiem { get; set; }
        public string UserTao { get; set; }
        public long NgayTao { get; set; }
        public string UserSua { get; set; }
        public Nullable<long> NgaySua { get; set; }
    
        public virtual ICollection<DM_TaiKhoan> DM_TaiKhoan { get; set; }
        public virtual ICollection<DT_HoSoKiemNghiem> DT_HoSoKiemNghiem { get; set; }
        public virtual ICollection<DT_PhieuPhanTichChiTieu> DT_PhieuPhanTichChiTieu { get; set; }
    }
}
