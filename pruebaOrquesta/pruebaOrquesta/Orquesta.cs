using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaOrquesta
{
  class Orquesta
  {
    public string nombre;
    public string lugar;
    public TipoOrquesta tipo;
    public List<Musico> musicos;

    public enum TipoOrquesta { Sinfonica, Camara, Filarmonica}

    public Orquesta() { }

    public Orquesta ( string nombre, string lugar, TipoOrquesta orquesta)
    {
      this.nombre = nombre;
      this.lugar = lugar;
      this.tipo = orquesta;
      this.musicos = new List<Musico>();
    }

    public void setNombre (string nombre)
    {
      this.nombre = nombre;
    }

    public string getNombre()
    {
      return this.nombre;
    }

    public void setLugar(string lugar)
    {
      this.lugar = lugar;
    }

    public string getLugar()
    {
      return this.lugar;
    }

    public void setTipo(TipoOrquesta tipo)
    {
      this.tipo = tipo;
    }

    public TipoOrquesta getTipo()
    {
      return this.tipo;
    }

    public string getOrquestaToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendFormat("Nombre de Orquesta: {0}, Lugar: {1}, Tipo: {2}\n", this.nombre, this.lugar, this.tipo);
      return sb.ToString();
    }

    public static void ImprimirOrquesta(Orquesta or)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(or.getOrquestaToString());
      if (or.musicos.Count > 0)
      {
        sb.AppendFormat("Lista de Musicos\n");
        foreach (Musico element in or.musicos)
        {
          sb.AppendFormat("Musico: {0}\n",element.nombre);
          sb.AppendFormat("Instrumento: {0}\n", element.instrumento.nombre);
        }
      }else
      {
        sb.AppendFormat("NO HAY MUSICOS EN ESTA ORQUESTA");
      }
      Console.WriteLine("{0}", sb.ToString());
      Console.ReadLine();
    }
  }
}
