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
    
    public partial class Ishod_Pregleda
    {
        public Ishod_Pregleda()
        {
                
        }
        public Ishod_Pregleda(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    
        public virtual Pregled Pregleds { get; set; }
        public virtual Pregled_Specijaliste Pregled_Specijaliste1 { get; set; }
    }
}