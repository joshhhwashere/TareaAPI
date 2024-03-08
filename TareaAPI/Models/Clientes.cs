namespace TareaAPI.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string? Nombre { get; set; } // '?' para hacer la propiedad anulable
        public decimal MontoPendiente { get; set; }
    }
}
