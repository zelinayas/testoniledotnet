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
    
    public partial class WILAYAH
    {
        public WILAYAH()
        {
            this.PROFIL_PESERTA = new HashSet<PROFIL_PESERTA>();
        }
    
        public int ID_WILAYAH { get; set; }
        public string NAMA_WILAYAH { get; set; }
        public Nullable<int> LEVEL_WILAYAH { get; set; }
        public Nullable<int> PARENT { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
    
        public virtual ICollection<PROFIL_PESERTA> PROFIL_PESERTA { get; set; }
    }
}
