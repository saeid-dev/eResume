//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eResume
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education
    {
        public int ID { get; set; }
        public string FieldOfStudy { get; set; }
        public string Location { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Grade { get; set; }
        public string Dissertation { get; set; }
        public string ShortDesc { get; set; }
        public int AutorID { get; set; }
        public int DegreeID { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Degree Degree { get; set; }
    }
}