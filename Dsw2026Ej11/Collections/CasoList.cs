using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> _alumnos = new ();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add (alumno);
    }

    public List<Alumno> ObtenerAlumnos()
    {
        return _alumnos;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        return _alumnos.FirstOrDefault(alumno => alumno.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarAlumnoPorIndice(int index)
    {
        if (index < 0 || index >= _alumnos.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index),"Alumno inexistente");
        }

        _alumnos.RemoveAt(index);
    }
}
