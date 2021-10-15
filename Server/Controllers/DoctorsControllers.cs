using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Home2Med.Shared.Entity;

namespace Home2Med.Server.Controllers
{
    [ApiController]
    /* El [controller] tomará el nombre del controlador, en este caso DoctorsController */
    [Route("api/[controller]")]

    public class DoctorsController : ControllerBase
    {
    private readonly ApplicationDbContext context;
    /* Para crear el registro en la DB, debemos inyectar el DbContext en el contraolador */
        public DoctorsController(ApplicationDbContext context){
            this.context = context;
        }

        [HttpPost]

         /* La tarea retorna un int correspondiente al Id del Doctor creado */
        public async Task<ActionResult<int>> Post(Doctor doctor){
           /* Con el metodo add agregamos el registro en la DB */
            context.Add(doctor);
            /* Aplicamos los cambios en la DB, para guardar cambios de forma asíncrona con el await */
            await context.SaveChangesAsync();
            return doctor.Id;
        }
    }
}