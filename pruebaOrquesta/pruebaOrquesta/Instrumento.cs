using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaOrquesta
{
  class Instrumento
  {
    public string nombre;
    public TipoInstrumento tipo;

    public enum TipoInstrumento { Aire, Cuerdas, Percusion} 

    public Instrumento() { }

    public Instrumento(string nombre,TipoInstrumento tipo)
    {
      this.nombre = nombre;
      this.tipo = tipo;
     }
    public void setNombre(string nombre)
    {
      this.nombre = nombre;
    }
    public string getNombre()
    {
      return this.nombre;
    }
    public void setTipo (TipoInstrumento tipo)
    {
      this.tipo = tipo;
    }
    public TipoInstrumento getTipo()
    {
      return this.tipo;
    }

  }
}
