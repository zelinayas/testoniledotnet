//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFIL_PESERTA
    {
        public PROFIL_PESERTA()
        {
            this.PESERTA = new HashSet<PESERTA>();
        }
    
        public int ID_PROFIL { get; set; }
        public Nullable<int> ID_WILAYAH { get; set; }
        public string NAMA_PESERTA { get; set; }
        public string ALAMAT_PESERTA { get; set; }
        public string TEMPAT_LAHIR { get; set; }
        public Nullable<System.DateTime> TANGGAL_LAHIR { get; set; }
        public string NO_HP { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
    
        public virtual ICollection<PESERTA> PESERTA { get; set; }
        public virtual WILAYAH WILAYAH { get; set; }
    }
}
