//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class asset_accountingEntities : DbContext
    {
        public asset_accountingEntities()
            : base("name=asset_accountingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Connection_Point> Connection_Point { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<Hardware_Port> Hardware_Port { get; set; }
        public virtual DbSet<Hardware_Type> Hardware_Type { get; set; }
        public virtual DbSet<Maintenance_Staff> Maintenance_Staff { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Service_Type> Service_Type { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
