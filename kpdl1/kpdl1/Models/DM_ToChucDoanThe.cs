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
    
    public partial class DM_ToChucDoanThe
    {
        public DM_ToChucDoanThe()
        {
            this.DM_LoaiMau = new HashSet<DM_LoaiMau>();
            this.DM_ToChucDoanTheNhom = new HashSet<DM_ToChucDoanTheNhom>();
            this.DT_PhieuPhanTich = new HashSet<DT_PhieuPhanTich>();
        }
    
        public long ID { get; set; }
        public long DonViID { get; set; }
        public Nullable<long> ChaID { get; set; }
        public short STT { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool LaToChuc { get; set; }
        public bool LaDoanThe { get; set; }
        public bool LaTheoDoi { get; set; }
        public bool LaVanThu { get; set; }
        public string strSQL { get; set; }
        public string strSP { get; set; }
        public string FormName { get; set; }
        public string ReportName { get; set; }
        public bool HieuLuc { get; set; }
        public string GhiChu { get; set; }
        public string MaTruongPhong { get; set; }
        public bool LaLabo { get; set; }
        public bool CoLapPhieuPhanTich { get; set; }
        public string CanBoTruongPhong { get; set; }
        public Nullable<long> NgayTruongPhong { get; set; }
        public bool PhanMemHanhChinh { get; set; }
        public bool PhanMemKiemNghiem { get; set; }
        public bool PhanMemTaiSan { get; set; }
        public bool PhanMemVatTu { get; set; }
        public byte[] MauKyTu { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsCamQuan { get; set; }
    
        public virtual ICollection<DM_LoaiMau> DM_LoaiMau { get; set; }
        public virtual ICollection<DM_ToChucDoanTheNhom> DM_ToChucDoanTheNhom { get; set; }
        public virtual ICollection<DT_PhieuPhanTich> DT_PhieuPhanTich { get; set; }
    }
}
