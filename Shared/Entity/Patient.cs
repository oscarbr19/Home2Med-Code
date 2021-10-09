using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Home2Med.Shared.Entity
{
    public class Patient
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string PatientName{get;set;}
       [Range(1,4,ErrorMessage ="Seleccione una opción")]
       public int PatientDocumentType { get; set; }
       [Required(ErrorMessage ="El campo es requerido")]
       public string PatientDocument { get; set; }
       [Range(1,2,ErrorMessage ="Seleccione una opción")]
       public int PatientGender { get; set; } 
       [Required(ErrorMessage ="El campo es requerido")]  
       public string PatientPhone {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string PatientEPS {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string PatientAddress {get; set;}
      [Required(ErrorMessage ="El campo es requerido")]
       public string PatientGeorreferentiation {get; set;}      
       [Range(1,4,ErrorMessage ="Seleccione una opción")]
       public int PatientDiagnosis {get; set;}
       [Range(1,21,ErrorMessage ="Seleccione una opción")]
       public int PatientDoctor {get; set;}
       public string PatientPhoto { get; set;}
       public bool PatientStatus { get; set;}
    } 
}