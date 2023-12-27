namespace Reto2.Modelo
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}
