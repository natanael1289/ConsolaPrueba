
using AplicacionClase1;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Estudiante> listaEstudiantes = new List<Estudiante>();

int opcion = 0;

while (opcion != -1)
{
    Console.WriteLine("Bienvenido, ingrese una opción");
    Console.WriteLine("1 - Alta de Alumnos");
    Console.WriteLine("2 - Listado de Alumnos");
    Console.WriteLine("3 - Promedio de Notas");
    Console.WriteLine("4 - Estudiantes aprobados");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case -1: Console.WriteLine("Saliendo del sistema..."); break;

        case 1: AltaAlumno(); break;

        case 2: ListarAlumnos(); break;

        case 3: PromediosNotas(); break;

        case 4: MostrarAprobados(); break;


        default:
            Console.WriteLine("Opción incorrecta");
            break;
    }

}

void AltaAlumno()
{
    Console.WriteLine("Ingrese el ID");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el Nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la Edad");
    int edad = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la Nota");
    double nota = int.Parse(Console.ReadLine());

Estudiante nuevoEstudiante = new Estudiante(id, nombre, edad, nota);

listaEstudiantes.Add(nuevoEstudiante);

Console.WriteLine("Estudiante agregado");
}

void ListarAlumnos()
{
    foreach(Estudiante e in listaEstudiantes)
    {
        Console.WriteLine(e.ToString());
    }
}

void PromediosNotas()
{
    double total = 0;

    foreach (Estudiante e in listaEstudiantes)
    {
        total += e.Nota;
    }   

    Console.WriteLine("El promedio es de: " + total / listaEstudiantes.Count);
}

void MostrarAprobados()
{
    Console.WriteLine("Estudiantes aprobados:");

    foreach (Estudiante e in listaEstudiantes)
    {
        if (e.Nota > 60)
        {
            Console.WriteLine(e.Nombre);
        }
    }
}
