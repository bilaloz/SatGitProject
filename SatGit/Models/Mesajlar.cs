//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatGit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesajlar
    {
        public int MesajID { get; set; }
        public Nullable<int> GondericiID { get; set; }
        public Nullable<int> AliciID { get; set; }
        public Nullable<System.DateTime> MesajTarihi { get; set; }
        public Nullable<int> UrunID { get; set; }
        public string MesajIcerik { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}
