using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona1 p = new Persona1();
      Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", p.nombre, p.apellido, p.getEdad());
      Console.ReadLine();

      Persona1 personaDos = new Persona1("Mario","Rodriguez",30);
      Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", personaDos.nombre, personaDos.apellido, personaDos.getEdad());
      Console.ReadLine();

      personaDos.cumplirAnios();
      Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", personaDos.nombre, personaDos.apellido, personaDos.getEdad());
      Console.ReadLine();

    }
  }
}
