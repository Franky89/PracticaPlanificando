using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestionfuentes.Models
{
    public class Fuente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Identificador de Fuente")]
        public int FuenteID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Range(0, 40)]
        public int temperatura { get; set; }
        [Range(0, 10)]
        public int valoracion { get; set; }


    }
}