using System.Collections.Generic;

class Biblioteca
{
    private List<Libro> libros = new List<Libro>();

    public List<Libro> Libros => libros;

    public void AddLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void RemoveLibro(Libro libro)
    {
        libros.Remove(libro);
    }
}
