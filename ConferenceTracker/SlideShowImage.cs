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
    
    public partial class SlideShowImage
    {
        public int ImageID { get; set; }
        public int SlideShowID { get; set; }
        public string PictureFile { get; set; }
        public int PictureOrder { get; set; }
    
        public virtual SlideShow SlideShow { get; set; }
    }
}
