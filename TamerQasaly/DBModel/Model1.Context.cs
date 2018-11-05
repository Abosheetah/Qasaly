﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TamerQasalyDBEntities : DbContext
    {
        public TamerQasalyDBEntities()
            : base("name=TamerQasalyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActualProductivity> ActualProductivities { get; set; }
        public virtual DbSet<CalculationMethod> CalculationMethods { get; set; }
        public virtual DbSet<DependencyEquipment> DependencyEquipments { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentDefaultMeasurementType> EquipmentDefaultMeasurementTypes { get; set; }
        public virtual DbSet<EquipmentDefaultMeasurementType_Equipment> EquipmentDefaultMeasurementType_Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<MainRepository> MainRepositories { get; set; }
        public virtual DbSet<Office_Career> Office_Career { get; set; }
        public virtual DbSet<Office_CareerType> Office_CareerType { get; set; }
        public virtual DbSet<Office_Employee> Office_Employee { get; set; }
        public virtual DbSet<OperationCareer> OperationCareers { get; set; }
        public virtual DbSet<OperationEmployee> OperationEmployees { get; set; }
        public virtual DbSet<OperationEmployeeCareer> OperationEmployeeCareers { get; set; }
        public virtual DbSet<OperationEquipment> OperationEquipments { get; set; }
        public virtual DbSet<OperationGeneralData> OperationGeneralDatas { get; set; }
        public virtual DbSet<OperationProductivity> OperationProductivities { get; set; }
        public virtual DbSet<OperationReopsitory> OperationReopsitories { get; set; }
        public virtual DbSet<OperationRepositoryData> OperationRepositoryDatas { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<ProcurementOfficial> ProcurementOfficials { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductivityType> ProductivityTypes { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual DbSet<RunTime> RunTimes { get; set; }
        public virtual DbSet<SupplierCategory> SupplierCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TempPurchaseOrder> TempPurchaseOrders { get; set; }
        public virtual DbSet<TempPurchaseOrderItem> TempPurchaseOrderItems { get; set; }
    }
}
