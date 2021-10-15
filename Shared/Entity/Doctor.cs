using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System;


namespace Home2Med.Shared.Entity
{
    public class Doctor
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string Name{get;set;}
       [Range(1,3,ErrorMessage ="Seleccione una opción")]
       public int DocumentType {get;set;}
       [Required(ErrorMessage ="El campo es requerido")]
       public string Document {get;set;}
       [Range(1,2,ErrorMessage ="Seleccione una opción")]
       public int Gender {get;set;}   
       [Required(ErrorMessage ="El campo es requerido")]
       public string Phone {get;set;}
       [Range(1,99,ErrorMessage ="Seleccione una opción")]
       public int Speciality {get;set;}
       public string Photo { get; set; }
       public bool Status {get;set;}
       /*public int PatientId {get;set;}
       public Patient Patient {get; set;}*/
       public List<Patient> Patients {get; set;}

    }
}    
