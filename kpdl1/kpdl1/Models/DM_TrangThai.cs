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
    
    public partial class DM_TrangThai
    {
        public DM_TrangThai()
        {
            this.DT_HoSoKiemNghiem = new HashSet<DT_HoSoKiemNghiem>();
        }
    
        public long ID { get; set; }
        public short STT { get; set; }
        public string Ten { get; set; }
        public short GiaTri { get; set; }
        public Nullable<long> Color { get; set; }
        public bool LaKetThuc { get; set; }
    
        public virtual ICollection<DT_HoSoKiemNghiem> DT_HoSoKiemNghiem { get; set; }
    }
}
