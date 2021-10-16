using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Home2Med.Server.Storage
{
    public class FilesStorageClass: IFilesStorageClass
    {
        private string connectionString;
        public FilesStorageClass(IConfiguration configuration){
            connectionString= configuration.GetConnectionString("AzureStorage");
        }
        /* Cargar la imagen en AzureStorage cada vez que cree un actor*/
        public async Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta){
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            client.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.Blob);
            /* Guid nos permitira crear nombres de imagenes aleatoriamente, para evitar duplicados */
            var fileName = $"{Guid.NewGuid()}{extension}";
            var blob = client.GetBlobClient(fileName);
            using(var memoryStream = new MemoryStream(contenido)){
                await blob.UploadAsync(memoryStream);
            };
            /* retornaremos la URL de la imagen */
            return blob.Uri.ToString();
        }

        /* Eliminar la foto una vez elimine el recurso por el Id */
        public async Task DeleteFile(string ruta, string nombreCarpeta){
            if (string.IsNullOrEmpty(ruta))
            {
                return;
            }
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            /* La ruta que capturamos en el GetFileName es la que devuelve el Task SaveFile */
            var fileName = Path.GetFileName(ruta);
            var blob = client.GetBlobClient(fileName);
            await blob.DeleteIfExistsAsync();
        }
        public async Task<string> EditFile(byte[] contenido,string extension, string nombreCarpeta,string ruta){
            await DeleteFile(ruta, nombreCarpeta);
            return await SaveFile(contenido, extension,nombreCarpeta);
        }
    }
}