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
    
    public partial class EquipmentDefaultMeasurementType_Equipment
    {
        public int EquipmentID { get; set; }
        public short EquipmentDefaultMeasurementTypeID { get; set; }
        public Nullable<decimal> Measure1 { get; set; }
        public Nullable<decimal> Measure2 { get; set; }
        public Nullable<decimal> Measure3 { get; set; }
        public Nullable<decimal> Measure4 { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentDefaultMeasurementType EquipmentDefaultMeasurementType { get; set; }
    }
}
