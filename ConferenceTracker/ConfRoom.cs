//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConfRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfRoom()
        {
            this.SchCalendars = new HashSet<SchCalendar>();
        }
    
        public int RoomID { get; set; }
        public string Name { get; set; }
        public string GName { get; set; }
        public bool Polycom { get; set; }
        public string Location { get; set; }
        public string CalUri { get; set; }
        public bool Visible { get; set; }
        public string Abbreviation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchCalendar> SchCalendars { get; set; }
    }
}
