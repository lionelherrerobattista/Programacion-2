using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  abstract class Persona
  {
    private string apellido;
    private int dni;
    private int edad;
    private string nombre;

    public string Apellido
    {
      get
      {
        return this.apellido;
      }
    }

    public int Dni
    {
      get
      {
        return this.dni;
      }
    }

    public int Edad
    {
      get
      {
        return this.edad;
      }
    }

    public string Nombre
    {
      get
      {
        return this.nombre;
      }
    }

    public virtual string Mostrar()
    {
      StringBuilder datos = new StringBuilder();

      datos.AppendFormat("{0} {1} {2} {3}", this.Apellido, this.Dni, this.Edad, this.Nombre);

      return datos.ToString();

    }

    public Persona(string nombre, string apellido, int edad, int dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
      this.dni = dni;
    }

    public abstract bool ValidarAptitud();
    
  }

  class DirectorTecnico : Persona
  {
    private int añosExperiencia;

    public int AñosExperiencia
    {
      get
      {
        return añosExperiencia;
      }
      set
      {
        this.añosExperiencia = value;
      }
    }

    public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
      : base(nombre, apellido, edad, dni)
    {
      this.añosExperiencia = añosExperiencia;

    }

    public override string Mostrar()
    {
      string datosTecnico;

      datosTecnico = base.Mostrar();

      datosTecnico = String.Format("{0} {1}", datosTecnico, this.AñosExperiencia);

      return datosTecnico;

    }

    public override bool ValidarAptitud()
    {
      bool esValido = false;


      if (this.Edad < 65 && this.AñosExperiencia >= 2)
      {
        esValido = true;
      }

      return esValido;

    }

  }

  class Jugador : Persona
  {
    private float altura;
    private float peso;
    private Posicion posicion;

    public float Altura
    {
      get
      {
        return this.altura;
      }
    }

    public float Peso
    {
      get
      {
        return this.peso;
      }
    }

    public Posicion Posicion
    {
      get
      {
        return this.posicion;
      }
    }

    public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
      : base(nombre, apellido, edad, dni)
    {
      this.altura = altura;
      this.peso = peso;
      this.posicion = posicion;
    }

    public override string Mostrar()
    {
      string datosJugador;

      datosJugador = String.Format("{0} {1} {2} {3}", base.Mostrar(), this.Altura, this.Peso, this.Posicion);

      return datosJugador;

    }

    
    public override bool ValidarAptitud()
    {
      bool esApto = false;

      if(this.Edad < 40 && this.ValidarEstadoFisico() == true)
      {
        esApto = true;
      }

      return esApto;
    }

    public bool ValidarEstadoFisico()
    {
      double IMC;
      bool esApto = false;

      IMC = Math.Pow((this.Peso / this.Altura), 2);

      if(IMC <= 25 && IMC >= 18.5)
      {
        esApto = true;
      }

      return esApto;
  
    }
  }



}

