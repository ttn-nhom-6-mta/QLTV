//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuMuonTra
    {
        public string MaCuonSach { get; set; }
        public string MaPhieuMuonTra { get; set; }
        public string MaVP { get; set; }
        public string TinhTrangTra { get; set; }
    
        public virtual CuonSach CuonSach { get; set; }
        public virtual PhieuMuonTra PhieuMuonTra { get; set; }
        public virtual ViPham ViPham { get; set; }
    }
}
