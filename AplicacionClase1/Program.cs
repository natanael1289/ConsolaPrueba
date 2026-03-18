
using AplicacionClase1;

List<Estudiante> listaEstudiantes = new List<Estudiante>();
int opcion = 0;


while(opcion != -1)
{
    Console.WriteLine("Bienvenido , ingrese una opcion");
    Console.WriteLine("1 - Alta de alumnos");
    Console.WriteLine("2 - Listado de alumnos");
    Console.WriteLine("3 - Promedio de alumnos");
    Console.WriteLine("4 - Alumnos con aprobados");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case -1: Console.WriteLine("Saliendo del sistema..."); break;

        case 1: AltaAlumno(); break;

        case 2: ListarAlumnos(); break;

        case 3: PromediosNota(); break;

        case 4: MostrarAprobados(); break;

        default: Console.WriteLine("Opcion rechazada"); break; 
    }

}

void AltaAlumno()
{
    Console.WriteLine("Ingrese el Nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la edad");
    int edad = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la nota");
    int nota = int.Parse(Console.ReadLine());

    Estudiante nuevoEstudiante = new Estudiante(nombre,edad,nota);

    listaEstudiantes.Add(nuevoEstudiante);

    Console.WriteLine("Estudiante agregado");

}

void ListarAlumnos()
{
    //foreach(Estudiante e in listaEstudiantes)
    //{
    //    Console.WriteLine(e.ToString());
    //}

    listaEstudiantes.ForEach(e => Console.WriteLine(e.ToString()));
}


void PromediosNota()
{
    int total = 0;

    foreach(Estudiante e in listaEstudiantes)
    {
        total += e.Nota;
    }

    Console.WriteLine("El promedio es: " + total / listaEstudiantes.Count);
} 

void MostrarAprobados()
{
    foreach(Estudiante e in listaEstudiantes)
    {
        if(e.Nota > 60)
        {
            Console.WriteLine("Aprobado: " + e.ToString());
        }
    }
}