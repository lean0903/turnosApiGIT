namespace apiTurnos.Models
{
    public class Rol
    {
        public int id { get; set; }
        public string descripcion{ get; set; }
        public string nombre { get; set; }
        public Usuario Usuario { get; set; }
    }
}