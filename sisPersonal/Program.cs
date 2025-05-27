using EspacioEmpleado;

Empleado empleado = new Empleado("ivan", "montañes", new DateTime(2005,1, 27), 'c', new DateTime(2010,4, 25), 650000, Cargos.Ingeniero);
Console.WriteLine($"antiguedad: {empleado.Antiguedad()}");
Console.WriteLine($"edad: {empleado.Edad()}");
Console.WriteLine($"anios para jubilarse: {empleado.AniosParaJubilarse()}");
Console.WriteLine($"adicional: {empleado.Salario()}");