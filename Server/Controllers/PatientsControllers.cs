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
    /* El [controller] tomará el nombre del controlador, en este caso PatientsController */
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        /* Para crear el registro en la DB, debemos inyectar el DbContext en el contraolador */
        public PatientsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        /* La tarea retorna un int correspondiente al Id del patient creado */
        public async Task<ActionResult<int>> Post(Patient patient)
        {
            /* Con el metodo add agregamos el registro en la DB */
            context.Add (patient);

            /* Aplicamos los cambios en la DB, para guardar cambios de forma asíncrona con el await */
            await context.SaveChangesAsync();
            return patient.Id;
        }
    }
}
