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
    
    public partial class Invertar
    {
        public Invertar()
        {
            this.Domjenak = new HashSet<Domjenak>();
        }
    
        public int id_invertar { get; set; }
        public string naziv { get; set; }
        public int kolicina { get; set; }
        public decimal cijena { get; set; }
    
        public virtual ICollection<Domjenak> Domjenak { get; set; }
    }
}
