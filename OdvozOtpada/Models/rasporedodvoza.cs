namespace OdvozOtpada.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rasporedodvoza")]
    public partial class rasporedodvoza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idRasporedaOdvoza { get; set; }

        public int idVrsteOtpada { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public int idUlice { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(45)]
        public string danTjednaOdvoza { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(45)]
        public string vrijemeOdvoza { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public int idGrad { get; set; }

        [StringLength(128)]
        public string datumKreiranja { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(45)]
        public string datumOdvoza { get; set; }

        public virtual grad grad { get; set; }

        public virtual otpad otpad { get; set; }

        public virtual ulica ulica { get; set; }
    }
}
