//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamerQasaly.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperationGeneralData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationGeneralData()
        {
            this.OperationEmployeeCareers = new HashSet<OperationEmployeeCareer>();
            this.OperationEquipments = new HashSet<OperationEquipment>();
            this.OperationProductivities = new HashSet<OperationProductivity>();
        }
    
        public int ID { get; set; }
        public string OperationName { get; set; }
        public string OperaionLocation { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationEmployeeCareer> OperationEmployeeCareers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationEquipment> OperationEquipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationProductivity> OperationProductivities { get; set; }
    }
}
