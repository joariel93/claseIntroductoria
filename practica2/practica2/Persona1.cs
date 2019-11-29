using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
  class Persona1
  {
           int edad;
    public string nombre;
    public string apellido;

    public Persona1() { }

    public Persona1(string nombre, string apellido, int edad) {

      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
    }

    public void setEdad(int edad)
    {
      int retorno = -1;
      this.edad = edad;
    }
    public int getEdad()
    {
      return this.edad;
    }
    public void cumplirAnios()
    {
      this.edad++;
    }

  }
}
