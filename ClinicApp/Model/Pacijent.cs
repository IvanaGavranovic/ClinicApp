//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pacijent : Korisnik
    {
        public Pacijent()
        {
            this.Pregleds = new HashSet<Pregled>();
            this.Pregled_Specijaliste = new HashSet<Pregled_Specijaliste>();
        }

        public Pacijent(string ime, string prezime, string kontakt, string ulica, string broj, string grad, string email, string korisnickoIme, string lozinka, string v) : base(ime, prezime, kontakt, ulica, broj, grad, email, korisnickoIme, lozinka, v)
        {
        }

        public virtual Departman Departmen { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<Pregled_Specijaliste> Pregled_Specijaliste { get; set; }
    }
}
