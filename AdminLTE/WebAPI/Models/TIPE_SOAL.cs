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
    
    public partial class TIPE_SOAL
    {
        public TIPE_SOAL()
        {
            this.SOAL = new HashSet<SOAL>();
        }
    
        public int ID_TIPESOAL { get; set; }
        public string NAMA_TIPE { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
    
        public virtual ICollection<SOAL> SOAL { get; set; }
    }
}
