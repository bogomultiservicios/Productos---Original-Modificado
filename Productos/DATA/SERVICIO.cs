namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVICIO")]
    public partial class SERVICIO
    {
        [Key]
        public int CODIGOSERVICIO { get; set; }

        [Column("SERVICIO")]
        [StringLength(50)]
        public string SERVICIO1 { get; set; }

        public decimal? COSTO { get; set; }

        public decimal? COSTOVENTA { get; set; }

        public decimal? IVA { get; set; }

        public decimal? PRECIO { get; set; }

        public int? CANTIDAD { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }
    }
}
