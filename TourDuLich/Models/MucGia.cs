//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourDuLich.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MucGia
    {
        public int ID_MucGia { get; set; }
        public Nullable<double> Gia { get; set; }
    
        public virtual TourDuLich TourDuLich { get; set; }
    }
}
