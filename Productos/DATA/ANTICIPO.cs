namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANTICIPO")]
    public partial class ANTICIPO
    {
        [Key]
        public int CODANTICIPO { get; set; }

        public decimal? CANTANTICIPO { get; set; }

        public decimal? PORCENTANTICIPO { get; set; }

        public int? CodCliente { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }

        public int? CODVENTA { get; set; }

        public virtual PROSECLIE PROSECLIE { get; set; }
    }
}
