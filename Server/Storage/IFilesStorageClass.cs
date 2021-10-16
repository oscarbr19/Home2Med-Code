using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Home2Med.Server.Storage
{
    public interface IFilesStorageClass
    {
         Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta);
         Task DeleteFile(string ruta, string nombreCarpeta);
         Task<string> EditFile(byte[] contenido,string extension, string nombreCarpeta,string ruta);
    }
}