using System.ComponentModel.DataAnnotations;

namespace HolaMVC.Models
{
    public class Persona
    {
        [Required(ErrorMessage="Escriba su nombre")]
        [MinLength(4,ErrorMessage="Escriba al menos 5 caracteres")]
        [MaxLength(50,ErrorMessage="Escriba un maximo de 50 caracteres")]
        public string Nombres{get;set;}

        [Required(ErrorMessage="Escriba su apellido")]
        [MinLength(4,ErrorMessage="Escriba al menos 5 caracteres")]
        [MaxLength(50,ErrorMessage="Escriba un maximo de 50 caracteres")]
        public string Apellidos{get;set;}

        [Required(ErrorMessage="Escriba su DNI")]
        [RegularExpression("^[0-9]{9}-[0-9]{1}$",ErrorMessage = "Escriba su DNI valido")]
        public string DNI{get;set;}

        [Required(ErrorMessage="Escriba su correo")]
        [EmailAddress(ErrorMessage = "Escriba un correo valido")]
        public string Correo{get;set;}

        public bool EstaActivo{get;set;}

        [Required(ErrorMessage="Escriba su fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento{get;set;}

        [Required(ErrorMessage="Escriba su edad")]
        [Range(18,120, ErrorMessage ="El registro es solo para personas mayores de 18 años")]
        public int Edad{get;set;}
        
    }
}