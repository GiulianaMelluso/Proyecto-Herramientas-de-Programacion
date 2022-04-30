using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Model
{
    public class Book
    {
        public string LengthError(int min, int max){
            return "El campo debe contener entre " + min + " y " + max + " caracteres.";
        }


   
        [MaxLength(20, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres.")]
        [MinLength(2, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres")]
        [Required (ErrorMessage = "El campo es obligatorio")]
        public string Title {get;set;}

        
        [MaxLength(20, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres.")]
        [MinLength(2, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres")]
        [Required (ErrorMessage = "El campo es obligatorio")]
        public string Author {get;set;}




        [MaxLength(20, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres.")]
        [MinLength(2, ErrorMessage = "El campo debe contener entre 3 y 15 caracteres")]
        [Required (ErrorMessage = "El campo es obligatorio")]
        public string Genre {get;set;}



        [Range(100,999, ErrorMessage ="Por favor ingrese un número entre 100 y 999")]
        [Required (ErrorMessage = "El campo es obligatorio")]
        public int ISBN {get;set;}

        public bool Borrowed {get;set;}

        public int Member_Id {get;set;}


    }
}