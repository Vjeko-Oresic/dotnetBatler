//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klijent
    {
        public Klijent()
        {
            this.Domjenak = new HashSet<Domjenak>();
        }
    
        public int id_klijent { get; set; }
        public string imePrezime1 { get; set; }
        public string imePrezime2 { get; set; }
        public int brojTel1 { get; set; }
        public Nullable<int> brojTel2 { get; set; }
        public string adresa1 { get; set; }
        public string adresa2 { get; set; }
        public string adresa_domjenak { get; set; }
    
        public virtual ICollection<Domjenak> Domjenak { get; set; }
    }
}