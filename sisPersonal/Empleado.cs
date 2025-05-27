namespace EspacioEmpleado
{
        public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista, 
        Investigador
    }
    public class Empleado
    {
        // campos //
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        // propiedades //
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        // metodos //
        // constructor //
        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }
        // metodo privado para calcular la diferencia entre    fechas //
        private int DiferenciaFechas(DateTime fecha)
        {
            // calculamos la diferencia //
            DateTime fechaActual = DateTime.Now;
            int diferencia = fechaActual.Year - fecha.Year;
            if (fechaActual.Month < fecha.Month)
            {
                diferencia--;
            }
            else if (fechaActual.Month == fecha.Month)
            {
                if (fechaActual.Day < fecha.Day)
                {
                    diferencia--;
                }
            }
            return diferencia;
        }

        public int Antiguedad()
        {
            // calculamos la antiguedad //
            int antiguedad = DiferenciaFechas(fechaIngreso);
            return antiguedad;
        }

        public int Edad()
        {
            // calculamos la edad //
            int edad = DiferenciaFechas(fechaNac);
            return edad;
        }

        public int AniosParaJubilarse()
        {
            int aniosRestantes = 65 - Edad();
            return aniosRestantes;
        }

        // metodo para calcular el adicional //
        private double CalcularAdicional()
        {
            double adicional = 0;
            int antiguedad = Antiguedad();
            // calculamos el aumento respecto de la antiguedad //
            if (antiguedad >= 0 && antiguedad <= 20)
            {
                adicional += antiguedad * sueldoBasico / 100;
            }
            else if (antiguedad > 20)
            {
                adicional += 25 * sueldoBasico / 100;
            }

            // calculamos el aumento segun el cargo //
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            // calculamos el aumento segun si es casado o no //
            if (estadoCivil == 'c' || EstadoCivil == 'C')
            {
                adicional += 150000;
            }

            return adicional;
        }
        public double Salario()
        {
            // calculamos el adicional //
            double adicional = CalcularAdicional();
            return adicional;
        }
    }
}
