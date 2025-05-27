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
        private string estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;
    
        // propiedades //
        public string Nombre { get => nombre; set => nombre =   value; }
        public string Apellido { get => apellido; set => apellido   = value; }
        public DateTime FechaNac { get => fechaNac; set =>  fechaNac = value; }
        public string EstadoCivil { get => estadoCivil; set =>  estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set =>  fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set =>    sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }
    
        // metodos //
        // constructor //
        public Empleado(string nombre, string apellido, DateTime    fechaNac, string estadoCivil, DateTime fechaIngreso,   double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }
        // metodo privada para calcular la diferencia entre     fechas //
        private int diferenciaFechas(DateTime fecha)
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
    
        public int antiguedad()
        {
            // calculamos la antiguedad //
            int antiguedad = diferenciaFechas(fechaIngreso);
            return antiguedad;
        }
    
        public int edad()
        {
            // calculamos la edad //
            int edad = diferenciaFechas(fechaNac);
            return edad;
        }
    
        public int aniosParaJubilarse()
        {
            int aniosRestantes = 65 - edad();
            return aniosRestantes;
        }
    }
}
