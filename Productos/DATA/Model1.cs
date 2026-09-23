namespace Productos.DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ANTICIPO> ANTICIPOes { get; set; }
        public virtual DbSet<LISTPRODUSERVVEN> LISTPRODUSERVVENs { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTOes { get; set; }
        public virtual DbSet<PROSECLIE> PROSECLIEs { get; set; }
        public virtual DbSet<PROSERVLIST> PROSERVLISTs { get; set; }
        public virtual DbSet<SERVICIO> SERVICIOs { get; set; }
        public virtual DbSet<VENTA> VENTAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
