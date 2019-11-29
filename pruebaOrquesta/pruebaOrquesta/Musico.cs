using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaOrquesta
{
  class Musico
  {
    public string nombre;
    public string apellido;
    public int edad;
    public Instrumento instrumento;
    //public Orquesta orquesta;

    public Musico(string nombre, string apellido, int edad, Instrumento ints) {

      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
      this.instrumento = ints;
      //this.orquesta = orqs;
      
    }

  }
}
