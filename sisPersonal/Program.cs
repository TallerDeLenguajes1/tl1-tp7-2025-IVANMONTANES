using EspacioEmpleado;
Empleado empleado1 = new Empleado("ivan", "montañes", new DateTime(2005, 1, 27), 'c', new DateTime(2010, 4, 25), 2650000, Cargos.Ingeniero);
Empleado empleado2 = new Empleado("santiago", "gonzalez", new DateTime(2005, 2, 14), 's', new DateTime(2022, 5, 5), 1200000, Cargos.Ingeniero);
Empleado empleado3 = new Empleado("fran", "graib", new DateTime(2004, 4, 28), 'c', new DateTime(2021, 4, 15), 1000000, Cargos.Administrativo);
Empleado[] empleados = {empleado1,empleado2,empleado3};
// obtenemos el monto de lo que se paga por salarios y el empleado mas proximo a jubilarse//
double salarios = 0;
int menor = 100, indice = default;
for (int i = 0; i < empleados.Length; i++)
{
    if (empleados[i].AniosParaJubilarse() <= menor)
    {
        menor = empleados[i].AniosParaJubilarse();
        indice = i;
    }
    salarios += empleados[i].Salario();
}
Console.WriteLine("**EMPLEADO MAS PROXIMO A JUBILARSE**");
empleados[indice].mostrarDatos();
Console.WriteLine($"Monto Total en salarios = {salarios}$");