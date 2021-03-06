//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamerQasaly.Data.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperationEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationEquipment()
        {
            this.ActualProductivities = new HashSet<ActualProductivity>();
            this.RunTimes = new HashSet<RunTime>();
        }
    
        public int ID { get; set; }
        public Nullable<int> OperationID { get; set; }
        public Nullable<int> EquipmentID { get; set; }
        public Nullable<short> CalculationMethodID { get; set; }
        public Nullable<System.DateTime> AgreementDate { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Decription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActualProductivity> ActualProductivities { get; set; }
        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual OperationGeneralData OperationGeneralData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunTime> RunTimes { get; set; }
    }
}
