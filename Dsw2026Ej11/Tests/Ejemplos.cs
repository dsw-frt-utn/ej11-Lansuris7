using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Net.Sockets;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos

    // CREACION DE ALUMNOS
    private static readonly Alumno alumno1 = new Alumno(45667, "Franco", 8.6);
    private static readonly Alumno alumno2 = new Alumno(66123, "Analia", 7.2);
    private static readonly Alumno alumno3 = new Alumno(46553, "Lucio", 9.0);

    public static void EjemploList()
    {
        var lista = new CasoList();

        lista.AgregarAlumno(alumno1);
        lista.AgregarAlumno(alumno2);
        lista.AgregarAlumno(alumno3);

        Console.WriteLine("*** Lista de alumnos ***");
        foreach (var alumno in lista.ObtenerAlumnos())
            Console.WriteLine(alumno);

        Console.WriteLine("\n*** Busqueda de alumno ***");
        Console.WriteLine(lista.BuscarAlumno("Franco")?.ToString());

        Console.WriteLine("\n*** Busqueda de alumno ***");
        var result = lista.BuscarAlumno("Romina");
        Console.WriteLine(result?.ToString() ?? "No existe");

        Console.WriteLine("\n*** Eliminación de alumno ***");
        var eliminado = lista.BuscarAlumno("Lucio");
        
        if(eliminado != null)
            lista.EliminarAlumno(eliminado);

        foreach (var alumno in lista.ObtenerAlumnos())
            Console.WriteLine(alumno);

        Console.WriteLine("\n*** Eliminación primer alumno ***");
        lista.EliminarAlumnoPorIndice(0);
        
        foreach (var alumno in lista.ObtenerAlumnos())
            Console.WriteLine(alumno);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var diccionario = new CasoDictionary();

        diccionario.AgregarAlumno(alumno1);
        diccionario.AgregarAlumno(alumno2);
        diccionario.AgregarAlumno(alumno3);

        Console.WriteLine("*** Diccionario de alumnos ***");
        foreach (KeyValuePair<int, Alumno> item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }

        Console.WriteLine("\n*** Busqueda de alumno ***");
        Console.WriteLine(diccionario.BuscarAlumno(45667)?.ToString());

        Console.WriteLine("\n*** Busqueda de alumno ***");
        Console.WriteLine(diccionario.BuscarAlumno(46465)?.ToString() ?? "No existe");

        Console.WriteLine("\n*** Eliminación de alumno ***");
        diccionario.EliminarAlumno(66123);
        
        foreach (KeyValuePair<int, Alumno> item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new ();

        Console.WriteLine($"Primero: {linq.GetPrimero()}");
        Console.WriteLine($"\nUltimo: {linq.GetUltimo()}");
        Console.WriteLine($"\nTotal: {linq.GetTotalPrecios()}");
        Console.WriteLine($"\nPromedio: {linq.GetPromedioPrecios():F2}");

        Console.WriteLine("\n\nListado de libros de id mayor a 15:\n");
        foreach (var libro in linq.GetListById())
        {
            Console.WriteLine(libro.ToString());
        }

        Console.WriteLine("\n\nListado de libros con formato:\n");
        foreach (var libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine($"\n\nPrecio mas alto:{linq.GetMayorPrecio()}");
        Console.WriteLine($"\nPrecio mas bajo:{linq.GetMenorPrecio()}");

        Console.WriteLine("\n\nCon precio mayor al promedio:\n");
        foreach (var libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro.ToString());
        }

        Console.WriteLine("\n\nOrden Descendente:\n");
        foreach (var libro in linq.GetOrdenadosPorTitulo())
        {
            Console.WriteLine(libro.ToString());
        }
    }
}
