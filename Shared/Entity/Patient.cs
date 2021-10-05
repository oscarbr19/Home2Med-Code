using System;
using System.ComponentModel.DataAnnotations;

namespace Home2Med.Shared.Entity
{
    public class Patient
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string Name{get;set;}
       public PatientDocumentType PatientDocumentType { get; set; }
       public string Document { get; set; }
       public PatientGender PatientGender { get; set; }   
       public string Phone {get;set;}
       public string EPS {get;set;}
       public string Address {get; set;}
       public PatientDiagnosis PatientDiagnosis {get; set;}
       public PatientDoctor PatientDoctor {get; set;}
       public string Photo { get; set;}
       public string Status { get; set;}
    }

    public enum PatientDocumentType
   {
      CedulaCiudadania  = 0,
      CedulaExtranjeria = 1
   }
   public enum PatientGender
   {
      Femenino = 0,
      Masculino = 1
   }

   public enum PatientDiagnosis
   {
      Incapacitado = 0,
      EnTratamiento = 1,
      DeAlta = 2

   }

   
   public enum PatientDoctor
   {
      Doctor1 = 0,
      Doctor2 = 1,
      Doctor3 = 2,
      Doctor4 = 3
   }


}