namespace OdvozOtpada.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otpad")]
    public partial class otpad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public otpad()
        {
            rasporedodvoza = new HashSet<rasporedodvoza>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idOtpad { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(256)]
        public string vrstaOtpad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rasporedodvoza> rasporedodvoza { get; set; }
    }
}
