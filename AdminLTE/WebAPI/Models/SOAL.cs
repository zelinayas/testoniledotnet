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
    
    public partial class SOAL
    {
        public SOAL()
        {
            this.PESERTA_JAWABAN_DETAIL = new HashSet<PESERTA_JAWABAN_DETAIL>();
            this.PILIHAN_JAWABAN = new HashSet<PILIHAN_JAWABAN>();
        }
    
        public int ID_SOAL { get; set; }
        public Nullable<int> ID_KELOMPOKSOAL { get; set; }
        public Nullable<int> ID_TIPESOAL { get; set; }
        public string ISI_SOAL { get; set; }
        public Nullable<int> NILAI_SOAL { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
        public Nullable<int> ID_SUBTES { get; set; }
    
        public virtual KELOMPOK_SOAL KELOMPOK_SOAL { get; set; }
        public virtual ICollection<PESERTA_JAWABAN_DETAIL> PESERTA_JAWABAN_DETAIL { get; set; }
        public virtual ICollection<PILIHAN_JAWABAN> PILIHAN_JAWABAN { get; set; }
        public virtual TIPE_SOAL TIPE_SOAL { get; set; }
        public virtual SUBTES SUBTES { get; set; }
    }
}
