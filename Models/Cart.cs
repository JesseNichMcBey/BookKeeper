//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookKeeper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public string cartID { get; set; }
        public string listingID { get; set; }
        public string studentNo { get; set; }
        public string cartStatusID { get; set; }
    
        public virtual BookListing BookListing { get; set; }
        public virtual CartStatu CartStatu { get; set; }
        public virtual User User { get; set; }
    }
}
