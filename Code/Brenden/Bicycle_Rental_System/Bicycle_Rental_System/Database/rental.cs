//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicycle_Rental_System.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class rental
    {
        public int Rental_Number { get; set; }
        public string Student_Number { get; set; }
        public Nullable<int> Employee_Number { get; set; }
        public Nullable<int> Bicycle_Number { get; set; }
        public Nullable<System.DateTime> Rental_CheckOutTime { get; set; }
        public Nullable<System.DateTime> Rental_CheckInTime { get; set; }
    
        public virtual bicycle bicycle { get; set; }
        public virtual employee employee { get; set; }
        public virtual student student { get; set; }
    }
}
