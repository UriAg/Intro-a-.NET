﻿namespace CodeProject.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public DateOnly FechaContrato { get; set; }
        public bool IsActive { get; set; }

    }
}
