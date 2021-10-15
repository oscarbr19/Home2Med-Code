using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System;


namespace Home2Med.Shared.Entity
{
    public class Nurse
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string NurseName{get;set;}
       [Range(1,4,ErrorMessage ="Seleccione una opción")]       
       public int NurseDocumentType { get; set; }
       [Required(ErrorMessage ="El campo es requerido")]
       public string NurseDocument { get; set; }
       [Range(1,2,ErrorMessage ="Seleccione una opción")]       
       public int NurseGender { get; set; }   
       [Required(ErrorMessage ="El campo es requerido")]
       public string NursePhone {get;set;}
       [Range(1,99,ErrorMessage ="Seleccione una opción")]
       public int NurseSpeciality {get;set;}
       public string NursePhoto { get; set; }
       public bool NurseStatus {get;set;}
       public List <Patient> Patients {get; set;}
    }
  
}