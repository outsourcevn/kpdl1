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
    
    public partial class DM_ChiTieu
    {
        public DM_ChiTieu()
        {
            this.DT_PhieuPhanTichChiTieu = new HashSet<DT_PhieuPhanTichChiTieu>();
        }
    
        public long ID { get; set; }
        public long ToChucDoanTheID { get; set; }
        public Nullable<long> NhomLaboID { get; set; }
        public string Ten { get; set; }
        public byte[] TenRTF { get; set; }
        public string TenNgan { get; set; }
        public string TenCR { get; set; }
        public short STT { get; set; }
        public Nullable<long> ChiTieuID { get; set; }
        public Nullable<long> DonGia { get; set; }
        public Nullable<short> ThueVAT { get; set; }
        public long PhanLoaiThucPhamID { get; set; }
        public bool ViLas_ChiTieu { get; set; }
        public string GioiHanDinhLuong { get; set; }
        public short SoNgayThucHien { get; set; }
        public Nullable<short> LuongMauToiThieu { get; set; }
        public string GhiChuLuongMau { get; set; }
        public Nullable<long> PhiThuNghiem1 { get; set; }
        public Nullable<long> PhiThuNghiem2 { get; set; }
        public Nullable<long> PhiThuNghiem3 { get; set; }
        public Nullable<long> KTNNPhiTN1 { get; set; }
        public string MaKiemNghiemVien { get; set; }
        public Nullable<long> NhomChiTieuID { get; set; }
        public Nullable<bool> LaDinhLuong { get; set; }
        public Nullable<bool> LaInNghieng { get; set; }
        public bool HieuLuc { get; set; }
        public Nullable<bool> BatBuocDonVi { get; set; }
        public Nullable<bool> BatBuocPhuongPhap { get; set; }
        public string UserTao { get; set; }
        public Nullable<long> NgayTao { get; set; }
        public string UserSua { get; set; }
        public Nullable<long> NgaySua { get; set; }
    
        public virtual ICollection<DT_PhieuPhanTichChiTieu> DT_PhieuPhanTichChiTieu { get; set; }
    }
}