//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLTE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class peserta_test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public peserta_test()
        {
            this.peserta_jawaban_detail = new HashSet<peserta_jawaban_detail>();
        }
    
        public long id { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string keterangan { get; set; }
        public string status { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public Nullable<long> peserta_id { get; set; }
        public Nullable<long> test_id { get; set; }
    
        public virtual peserta peserta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peserta_jawaban_detail> peserta_jawaban_detail { get; set; }
        public virtual test test { get; set; }
    }
}