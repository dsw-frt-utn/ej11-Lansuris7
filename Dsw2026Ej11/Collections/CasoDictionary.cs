using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> _alumnos = new();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        _alumnos.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        _alumnos.Remove(legajo);
    }
}
