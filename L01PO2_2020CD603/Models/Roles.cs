using System.ComponentModel.DataAnnotations;

namespace L01PO2_2020CD603.Models
{
    public class Roles
    {
        [Key]
        public int rolId { get; set; }
        public string? rol { get; set; }
    }
}
