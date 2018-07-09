using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BukuResult.Models
{
    public class Peminjaman
    {
       
        public string judul { get; set; }
        public DateTime tanggalPinjam { get; set; }
        public List<detailPinjam> detailpinjam { get; set; }
    }
}