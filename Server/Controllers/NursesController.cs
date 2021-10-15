using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home2Med.Shared.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Home2Med.Server.Controllers
{
    [ApiController]
    /* El [controller] tomará el nombre del controlador, en este caso NursesController */
    [Route("api/[controller]")]
    public class NursesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        /* Para crear el registro en la DB, debemos inyectar el DbContext en el contraolador */
        public NursesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        /* La tarea retorna un int correspondiente al Id del Nurse creado */
        public async Task<ActionResult<int>> Post(Nurse nurse)
        {
            /* Con el metodo add agregamos el registro en la DB */
            context.Add (nurse);

            /* Aplicamos los cambios en la DB, para guardar cambios de forma asíncrona con el await */
            await context.SaveChangesAsync();
            return nurse.Id;
        }
    }
}
