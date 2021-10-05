using Home2Med.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Home2Med.Client.Services
{
    public class ServiceDoctor : IServiceDoctor
    {
       public List<Doctor>GetDoctors(){
          return new List<Doctor>(){
             new Doctor(){Id = 1, Name = "Pedro Piedras", DocumentType= 1, Document="12345689", Gender= 2, Phone="3104789632", Speciality= 1, Photo="/Images/foto01.png", Status=true  },             
             new Doctor(){Id = 2 , Name = "Benito Camelas", DocumentType= 1, Document="234567890", Gender= 2, Phone="3171234789", Speciality= 1, Photo="/Images/foto01.png", Status=true},             
             new Doctor(){Id = 3 , Name = "Mamon Masmamon", DocumentType= 1, Document="345678901", Gender= 2, Phone="3140143694", Speciality= 1, Photo="/Images/foto01.png", Status=true},             
             new Doctor(){Id = 4 , Name = "Teresa Arrieta", DocumentType= 1, Document="456789012", Gender= 1, Phone="301010112", Speciality= 2, Photo="/Images/foto01.png", Status=true}
          };
       }
        
    }
}