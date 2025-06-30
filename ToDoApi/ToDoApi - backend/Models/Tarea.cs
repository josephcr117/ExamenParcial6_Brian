﻿namespace ToDoApi.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaLimite { get; set; }
        public bool Completada { get; set; }
        public int Prioridad { get; set; } // 1: Alta, 2: Media, 3: Baja
    }
}
