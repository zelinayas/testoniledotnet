//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PesertaNET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class test
    {
        public test()
        {
            this.peserta_test = new HashSet<peserta_test>();
            this.test_sub = new HashSet<test_sub>();
        }
    
        public long id { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string keterangan { get; set; }
        public string status { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string nama_test { get; set; }
        public string tgl_test { get; set; }
    
        public virtual ICollection<peserta_test> peserta_test { get; set; }
        public virtual ICollection<test_sub> test_sub { get; set; }
    }
}