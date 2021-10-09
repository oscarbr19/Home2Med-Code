using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Home2Med.Shared.Entity
{
    public class Relative
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string RelativeName{get;set;}
       [Range(1,4,ErrorMessage ="Seleccione una opción")]
       public int RelativeDocumentType { get; set; }
       [Required(ErrorMessage ="El campo es requerido")]
       public string RelativeDocument { get; set; }
       [Range(1,2,ErrorMessage ="Seleccione una opción")]
       public int RelativeGender { get; set; } 
       [Required(ErrorMessage ="El campo es requerido")]  
       public string RelativePhone {get;set;}
       [Range(1,10,ErrorMessage ="Seleccione una opción")]
       public int RelativeRelationship {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string RelativeEmail {get; set;}
      [Required(ErrorMessage ="El campo es requerido")]
       public string RelativePatientDoc {get; set;}      
       public string RelativePhoto { get; set;}
       public bool RelativeStatus { get; set;}
    } 
}