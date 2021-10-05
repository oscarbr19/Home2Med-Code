using System;
using System.ComponentModel.DataAnnotations;

namespace Home2Med.Shared.Entity
{
    public class Relative
    {
      public int Id {get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string Name{get;set;}
       public RelativeDocumentType RelativeDocumentType { get; set; }
       public string Document { get; set; }
       public string email {get; set;}
       public RelativeGender RelativeGender { get; set; }   
       public string Phone {get;set;}
       public RelativeRelationship RelativeRelationship {get;set;}
       public string Photo { get; set; } 
       public RelativePatient RelativePatient {get; set;} 
       public bool Status {get;set;}
    }
     public enum RelativeDocumentType
   {
      CedulaCiudadania  = 0,
      CedulaExtranjeria = 1
   }
   public enum RelativeGender
   {
      Femenino = 0,
      Masculino = 1
   }

   public enum RelativeRelationship
   {
      Conyuge = 0,
      Hermanos = 1,
      Padres = 2,
      Hijos = 3,
      Otro = 4
   }
   public enum RelativePatient
   {
      Patient1 = 0,
      Patient2 = 1,
      Patient3 = 2,
      Patient4 = 3
   }
}