using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleadosContext: DbContext
    {

        public DBEmpleadosContext(DbContextOptions<DBEmpleadosContext> options):base(options) { }


        public DbSet<Empleado> Empleados { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasData(
                new Empleado
                {
                    EmpleadoId = 1,
                    Nombre = "Joel",
                    Apellido = "Santos",
                    DNI = "44375391",
                    Legajo = "AA37472",
                    Titulo = "Comerciante"
                },
                new Empleado
                {
                    EmpleadoId = 2,
                    Nombre = "Pablo",
                    Apellido = "Rodriguez",
                    DNI = "38217313",
                    Legajo = "AA47283",
                    Titulo = "Abogado"
                });
        }

    }
}
