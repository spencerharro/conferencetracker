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
    
    public partial class SlideShow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SlideShow()
        {
            this.SlideShowImages = new HashSet<SlideShowImage>();
        }
    
        public int SlideShowID { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlideShowImage> SlideShowImages { get; set; }
        public virtual SlideShow SlideShows1 { get; set; }
        public virtual SlideShow SlideShow1 { get; set; }
    }
}
