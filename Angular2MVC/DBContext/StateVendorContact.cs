//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Angular2MVC.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class StateVendorContact
    {
        public int StateVendorContactId { get; set; }
        public Nullable<int> VendorContactId { get; set; }
        public Nullable<int> StateId { get; set; }
    
        public virtual State State { get; set; }
        public virtual VendorContact VendorContact { get; set; }
    }
}
