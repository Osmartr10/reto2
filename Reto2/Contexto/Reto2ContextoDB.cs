using Microsoft.EntityFrameworkCore;
using Reto2.Modelo;

namespace Reto2.Contexto
{
    public class Reto2ContextoDB : DbContext
    {
        public Reto2ContextoDB() { }
        public Reto2ContextoDB(DbContextOptions<Reto2ContextoDB> options) : base(options)
        {

        }
        public DbSet<Asignatura> Asignatura { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Enrolamiento> Enrolamiento { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Materia> Materia { get; set; }
    }
}
