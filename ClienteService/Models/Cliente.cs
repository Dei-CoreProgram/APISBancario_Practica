namespace ClienteService.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int PersonaId { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public Persona Persona { get; set; }
    }
}
