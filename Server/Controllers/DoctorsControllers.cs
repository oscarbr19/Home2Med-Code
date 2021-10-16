using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home2Med.Server.Storage;
using Home2Med.Shared.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Home2Med.Server.Controllers
{
    [ApiController]
    /* El [controller] tomará el nombre del controlador, en este caso DoctorsController */
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        /* Los únicos métodos que reciben como parámetro la entidad son:
         [HttpPost] => POST(Add) => Crear registro
         [HttpPut] => PUT (Attach) => Actualizar registro */
        /* El método que no recibe parámetro es:
         [HttpGet] => GET(ToListAsync) => Consultar historial de registros
         */
        /* Los métodos que reciben como parámetro el Id son:
         [HttpDelete("{id}")] => DELETE (Remove) => Eliminar registro
         [HttpGet("{id}")] => GET[{id}] (FirstOrDefaultAsync) => Consultar
         por un registro específico*/
        private readonly ApplicationDbContext context;

        private readonly IFilesStorageClass FilesStorage;

        private readonly string carpeta = "doctors";

        /* Para crear el registro en la DB, debemos inyectar el DbContext en el contraolador */
        public DoctorsController(
            ApplicationDbContext context,
            IFilesStorageClass filesStorage
        )
        {
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        /* La tarea retorna un int correspondiente al Id del Doctor creado */
        public async Task<ActionResult<int>> Post(Doctor doctor)
        {
            /* Con el metodo add agregamos el registro en la DB */
            if (!string.IsNullOrWhiteSpace(doctor.Photo))
            {
                var doctor_photo = Convert.FromBase64String(doctor.Photo);
                doctor.Photo =
                    await FilesStorage
                        .SaveFile(doctor_photo, ".jpg, .png", carpeta);
            }
            context.Add (doctor);

            /* Aplicamos los cambios en la DB, para guardar cambios de forma asíncrona con el await */
            await context.SaveChangesAsync();
            return doctor.Id;
        }

        /* Consultar registros en la base de datos (Lista TODOS los registros)*/
        [HttpGet]
        public async Task<ActionResult<List<Doctor>>> Get()
        {
            return await context.Doctors.ToListAsync();
        }

        /* Consultar la información de determinado recurso */
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> Get(int id)
        {
            return await context
                .Doctors
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        /* Actualizar información de determinado registro */
        [HttpPut]
        public async Task<ActionResult> Put(Doctor doctor)
        {
            context.Attach(doctor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Doctors.AnyAsync(x => x.Id == id);

            /* Si no existe un registro con ese Id */
            if (!exists)
            {
                return NotFound();
            }
            context.Remove(new Doctor { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
