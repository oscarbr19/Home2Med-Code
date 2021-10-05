using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class Nurse
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string Name{get;set;}
       public NurseDocumentType NurseDocumentType { get; set; }
       public string Document { get; set; }
       public NurseGender NurseGender { get; set; }   
       public string Phone {get;set;}
       public NurseSpeciality NurseSpeciality {get;set;}
       public string Photo { get; set; }
       public bool Status {get;set;}
    }
   public enum NurseDocumentType
   {
      CedulaCiudadania  = 0,
      CedulaExtranjeria = 1
   }
   public enum NurseGender
   {
      Femenino = 0,
      Masculino = 1
   }
   public enum NurseSpeciality
   {
      General = 0,
      Respiratoria = 1,
      CuidadosIntensivos = 2
   }

}