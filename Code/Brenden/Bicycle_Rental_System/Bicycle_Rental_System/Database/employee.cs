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
    
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.rentals = new HashSet<rental>();
        }
    
        public int Employee_Number { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Surname { get; set; }
        public int Employee_AccessLevel { get; set; }
        public Nullable<int> Employee_RoleID { get; set; }
        public string Employee_Password { get; set; }
    
        public virtual role role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rental> rentals { get; set; }
    }
}
