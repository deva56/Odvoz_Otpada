namespace OdvozOtpada.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ulica")]
    public partial class ulica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ulica()
        {
            rasporedodvoza = new HashSet<rasporedodvoza>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUlica { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(256)]
        public string imeUlica { get; set; }

        public int idGrada { get; set; }

        public virtual grad grad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rasporedodvoza> rasporedodvoza { get; set; }
    }
}
