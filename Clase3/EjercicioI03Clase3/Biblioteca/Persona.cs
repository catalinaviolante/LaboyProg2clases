using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;

        }

        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento();
        }

    }
}
