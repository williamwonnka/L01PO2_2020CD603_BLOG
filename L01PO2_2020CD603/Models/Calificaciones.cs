﻿using System.ComponentModel.DataAnnotations;

namespace L01PO2_2020CD603.Models
{
    public class Calificaciones
    {
        [Key]
        public int calificacionId { get; set; }
        public int publicacionId { get; set; }
        public int usuarioId { get; set; }
        public int calificacion { get; set; }
    }
}
