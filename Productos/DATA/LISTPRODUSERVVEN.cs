namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LISTPRODUSERVVEN")]
    public partial class LISTPRODUSERVVEN
    {
        [Key]
        public int CODLISTPRODUSERVVEN { get; set; }

        [Column("PRODUCTO/SERVICIO")]
        [StringLength(1000)]
        public string PRODUCTO_SERVICIO { get; set; }

        public int? CODVENTA { get; set; }

        public decimal? PRECIO_PRODUCTO { get; set; }

        public int? CANTIDAD_SOLICITADA { get; set; }

        [StringLength(10)]
        public string FECHAVENTA { get; set; }

        public TimeSpan? HORAVENTA { get; set; }

        public int? CODCLIENTE { get; set; }

        public decimal? SubTotProduServ { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }
    }
}
