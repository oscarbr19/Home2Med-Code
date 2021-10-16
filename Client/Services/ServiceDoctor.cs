using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Home2Med.Shared.Entity;
using Home2Med.Client.Services;

namespace Home2Med.Client.Services
{
    public class ServiceDoctor : IServiceDoctor
    {
        private readonly HttpClient httpClient;

        public ServiceDoctor(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        /* METODOS CREAR */
        public async Task<HttpResponseWrapper<object>>
        Post<T>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent =
                new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null,
                !responseHttp.IsSuccessStatusCode,
                responseHttp);
        }

        /* Los siguientes dos métodos nos permitiran obtener el Id de la pelicula que acabo de crear */
        private async Task<T>
        DeserializarRespuesta<T>(
            HttpResponseMessage httpResponse,
            JsonSerializerOptions jsonSerializerOptions
        )
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer
                .Deserialize<T>(responseString, jsonSerializerOptions);
        }

        public async Task<HttpResponseWrapper<TResponse>>
        Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent =
                new StringContent(enviarJSON,
                    Encoding.UTF8,
                    "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response =
                    await DeserializarRespuesta<TResponse>(responseHttp,
                    OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response,
                    false,
                    responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default,
                    true,
                    responseHttp);
            }
        }

        /* METODO CONSULTAR */
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response =
                    await DeserializarRespuesta<T>(responseHTTP,
                    OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response,
                    false,
                    responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null,!responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>()
            {
                new Doctor()
                {
                    Id = 1,
                    Name = "Pedro Piedras",
                    DocumentType = 1,
                    Document = "12345689",
                    Gender = 2,
                    Phone = "3104789632",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto01.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 2,
                    Name = "Benito Camelas",
                    DocumentType = 2,
                    Document = "234567890",
                    Gender = 2,
                    Phone = "3171234789",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto02.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 3,
                    Name = "Mamon Masmamon",
                    DocumentType = 3,
                    Document = "345678901",
                    Gender = 2,
                    Phone = "3140143694",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto03.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 4,
                    Name = "Teresa Arrieta",
                    DocumentType = 3,
                    Document = "456789012",
                    Gender = 1,
                    Phone = "301010112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto04.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 5,
                    Name = "Carlos Arrieta",
                    DocumentType = 2,
                    Document = "456789012",
                    Gender = 1,
                    Phone = "301010114",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto05.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 6,
                    Name = "Marcos Segura",
                    DocumentType = 1,
                    Document = "456789012",
                    Gender = 1,
                    Phone = "301010112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto06.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 7,
                    Name = "Marcela Segura",
                    DocumentType = 1,
                    Document = "456789012",
                    Gender = 2,
                    Phone = "301010112",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto07.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 8,
                    Name = "Dominique Nique Nique",
                    DocumentType = 1,
                    Document = "456789012",
                    Gender = 2,
                    Phone = "301010112",
                    Speciality = 3,
                    Photo = "/Images/medicos/foto08.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 9,
                    Name = "Efrain Caiman Sanchez",
                    DocumentType = 2,
                    Document = "456789012",
                    Gender = 1,
                    Phone = "301010112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto09.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 10,
                    Name = "Martín Emilio Cochise",
                    DocumentType = 3,
                    Document = "456789012",
                    Gender = 1,
                    Phone = "301010112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto10.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 11,
                    Name = "Elena No Crece",
                    DocumentType = 3,
                    Document = "456789012",
                    Gender = 2,
                    Phone = "301010112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto11.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 12,
                    Name = "Morticia Monster",
                    DocumentType = 2,
                    Document = "456789012",
                    Gender = 2,
                    Phone = "301010112",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto12.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 13,
                    Name = "Margarita Larrota",
                    DocumentType = 1,
                    Document = "456774012",
                    Gender = 2,
                    Phone = "301017412",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto13.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 14,
                    Name = "Magdalena Largacha",
                    DocumentType = 2,
                    Document = "987789012",
                    Gender = 2,
                    Phone = "301019875",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto14.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 15,
                    Name = "Virginia Tenjo",
                    DocumentType = 1,
                    Document = "451599012",
                    Gender = 2,
                    Phone = "317510112",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto15.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 16,
                    Name = "María Melo Masmela",
                    DocumentType = 1,
                    Document = "123489012",
                    Gender = 2,
                    Phone = "304571112",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto16.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 17,
                    Name = "Esperanza Rocio Manjarres",
                    DocumentType = 2,
                    Document = "745789012",
                    Gender = 2,
                    Phone = "310101121",
                    Speciality = 3,
                    Photo = "/Images/medicos/foto17.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 18,
                    Name = "Blanca Negrette",
                    DocumentType = 1,
                    Document = "487785012",
                    Gender = 2,
                    Phone = "3150104112",
                    Speciality = 4,
                    Photo = "/Images/medicos/foto18.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 19,
                    Name = "Natalia Mejia",
                    DocumentType = 3,
                    Document = "125458901",
                    Gender = 2,
                    Phone = "3178010257",
                    Speciality = 1,
                    Photo = "/Images/medicos/foto19.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 20,
                    Name = "Marco Puerta Segura",
                    DocumentType = 1,
                    Document = "197789012",
                    Gender = 1,
                    Phone = "3101127521",
                    Speciality = 2,
                    Photo = "/Images/medicos/foto20.jpg",
                    Status = true
                },
                new Doctor()
                {
                    Id = 21,
                    Name = "Sigifredo Pedro Marquez",
                    DocumentType = 1,
                    Document = "124569012",
                    Gender = 1,
                    Phone = "3153101122",
                    Speciality = 3,
                    Photo = "/Images/medicos/foto21.jpg",
                    Status = true
                }
            };
        }
    }
}
