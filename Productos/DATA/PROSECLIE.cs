namespace Productos.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROSECLIE")]
    public partial class PROSECLIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROSECLIE()
        {
            ANTICIPOes = new HashSet<ANTICIPO>();
        }

        [Key]
        public int CodCliente { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string DIRECCION { get; set; }

        [StringLength(20)]
        public string NIT { get; set; }

        [StringLength(8)]
        public string TELEFONO { get; set; }

        [StringLength(8)]
        public string ESTLIN { get; set; }

        [StringLength(25)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(25)]
        public string MUNICIPIO { get; set; }

        public int? CODVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANTICIPO> ANTICIPOes { get; set; }
    }
}
