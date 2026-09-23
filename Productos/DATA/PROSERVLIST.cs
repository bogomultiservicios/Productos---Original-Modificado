namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROSERVLIST")]
    public partial class PROSERVLIST
    {
        [Key]
        public int CODPROSERVLIST { get; set; }

        [Column("PRODUCTO/SERVICIO")]
        [StringLength(50)]
        public string PRODUCTO_SERVICIO { get; set; }

        public decimal? PRECIO { get; set; }

        [StringLength(8)]
        public string CLASIFICACION { get; set; }

        public int? STOCK { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }
    }
}
