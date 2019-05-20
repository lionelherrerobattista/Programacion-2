using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_36
{
    public class Competencia
    {

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;

            }
            set
            {
                this.cantidadCompetidores = value;

            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool agregoCompetidor = false;

            Random r = new Random();


            if (c.competidores.Count < c.cantidadCompetidores)
            {
                try
                {
                    if (c != a)
                    {
                        c.competidores.Add(a);
                        c.competidores[c.competidores.IndexOf(a)].EnCompetencia = true;
                        c.competidores[c.competidores.IndexOf(a)].VueltasRestantes = c.cantidadVueltas;
                        c.competidores[c.competidores.IndexOf(a)].CantidadCombustible = (short)r.Next(15, 101);

                        agregoCompetidor = true;
                    }
                }
                catch(CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "Operator +", e);
                }


            }

            return agregoCompetidor;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            int i;
            bool quito = false;

            for(i = 0; i < c.Competidores.Count; i++)
            {
                if(c[i] == a)
                {
                    quito = c.competidores.Remove(c[i]);
                }
            }

            return quito;
        }

        /// <summary>
        /// Devuelve true si el auto es del mismo tipo
        /// y no forma parte de la competencia
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            int i;
            bool sonIguales = false;

            TipoCompetencia tipo;

            tipo = c.Tipo;

            switch(tipo)
            {
                case Competencia.TipoCompetencia.F1:
                    if( a is AutoF1)
                    {
                        for (i = 0; i < c.competidores.Count; i++)
                        {

                            if (c[i] == a)
                            {
                                sonIguales = true;

                            }

                        }
                    }
                    else
                    {
                       
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia",
                            "Vehiculo", "operator ==");

                    }
                    break;

                case Competencia.TipoCompetencia.MotoCross:
                    if (a is MotoCross)
                    {
                        for (i = 0; i < c.competidores.Count; i++)
                        {

                            if (c[i] == a)
                            {
                                sonIguales = true;

                            }

                        }
                    }
                    else
                    {
                        
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia",
                            "Vehiculo", "operator ==");

                    }
                    break;

                default:
                   
                    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia",
                        "Vehiculo", "operator ==");

  
            }

            return sonIguales;

        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }


    }
}
