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
    
    public partial class DM_LoaiMau
    {
        public DM_LoaiMau()
        {
            this.DT_HoSoKiemNghiem = new HashSet<DT_HoSoKiemNghiem>();
        }
    
        public long ID { get; set; }
        public short STT { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenSo { get; set; }
        public string MaTangDan { get; set; }
        public bool GanKemMa { get; set; }
        public long ToChucDoanTheID { get; set; }
        public bool HieuLuc { get; set; }
        public string UserControl { get; set; }
        public Nullable<bool> DangKyNhapKhau { get; set; }
        public Nullable<bool> KTKNXacNhan { get; set; }
    
        public virtual DM_ToChucDoanThe DM_ToChucDoanThe { get; set; }
        public virtual ICollection<DT_HoSoKiemNghiem> DT_HoSoKiemNghiem { get; set; }
    }
}
