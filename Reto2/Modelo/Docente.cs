namespace Reto2.Modelo
{
    public class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

    }
}
