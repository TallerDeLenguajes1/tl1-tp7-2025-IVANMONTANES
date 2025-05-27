using EspacioEmpleado;

Empleado empleado = new Empleado("ivan", "montañes", new DateTime(2005,1, 27), "s", new DateTime(2020,6, 25), 950000, Cargos.Ingeniero);
Console.WriteLine($"antiguedad: {empleado.antiguedad()}");
Console.WriteLine($"edad: {empleado.edad()}");
Console.WriteLine($"anios para jubilarse: {empleado.aniosParaJubilarse()}");