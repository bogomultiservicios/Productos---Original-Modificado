namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTA")]
    public partial class VENTA
    {
        [Key]
        public int CODVENTA { get; set; }

        [Column("PRODUCTO/SERVICIO")]
        public int? PRODUCTO_SERVICIO { get; set; }

        [StringLength(10)]
        public string FECHAVENTA { get; set; }

        public decimal? PRECIO { get; set; }

        public int? CANTIDAD { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }

        public TimeSpan? HORAVENTA { get; set; }

        public int? CodCliente { get; set; }

        public decimal? ANTICIPO { get; set; }

        public decimal? CANTPAGAR { get; set; }

        [StringLength(20)]
        public string ESTPAGO { get; set; }
    }
}
