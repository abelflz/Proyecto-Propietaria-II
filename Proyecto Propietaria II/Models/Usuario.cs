using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Propietaria_II.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Debe digitar una cédula")]
        [StringLength(11)]
        public int Cedula { get; set; }

        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(30)]
        public string Apellido { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Correo no válido")]
        public string Correo { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
    }
}