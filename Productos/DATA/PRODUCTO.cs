namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTO")]
    public partial class PRODUCTO
    {
        [Key]
        public int CODPRODUCTO { get; set; }

        [Column("PRODUCTO")]
        [StringLength(50)]
        public string PRODUCTO1 { get; set; }

        public decimal? COSTO { get; set; }

        public decimal? COSTOVENTA { get; set; }

        public decimal? IVA { get; set; }

        public decimal? PRECIO { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }

        [StringLength(50)]
        public string PROVEEDOR { get; set; }

        public int? STOCK { get; set; }
    }
}
