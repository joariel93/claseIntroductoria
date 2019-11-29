using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaOrquesta
{
  class Program
  {
    static void Main(string[] args)
    {
      Orquesta or = new Orquesta("La Banda de mi Barrio", "Caballito", Orquesta.TipoOrquesta.Sinfonica);
      Console.WriteLine("Nombre de orquesta: {0}, Lugar: {1}\nTipo: {2}", or.nombre, or.lugar, or.tipo);
      Console.ReadLine();

      Instrumento instrumento = new Instrumento("Trompeta", Instrumento.TipoInstrumento.Aire);

      Musico musicoPrincipal = new Musico("Joaquin", "Calero", 25, instrumento);
      Console.WriteLine("Nombre y apellido del musico: {0} {1}, Edad {2}\nInstrumento: {3}\n", musicoPrincipal.nombre, musicoPrincipal.apellido, musicoPrincipal.edad, musicoPrincipal.instrumento.nombre);
      Console.ReadLine();

      Musico musicoSecundario = new Musico("Alvaro", "Calero", 21, instrumento);

      or.musicos.Add(musicoPrincipal);
      or.musicos.Add(musicoSecundario);

      Orquesta.ImprimirOrquesta(or);
    }
  }
}
