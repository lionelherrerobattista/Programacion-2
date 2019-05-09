using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this ()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Estacionamiento {0}\nEspacio disponible: {1}", e.nombre, e.espacioDisponible);
            datos.AppendLine();
            datos.Append("Vehículos:\n");
            datos.AppendLine();

            if(e.vehiculos.Count != 0)
            {
                foreach (Vehiculo v in e.vehiculos)
                {
                    datos.Append(v.ConsultarDatos());
                    datos.AppendLine();
                }
            }
            else
            {
                datos.Append("No hay vehículos");
            }


            return datos.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool sonIguales = false;

            foreach(Vehiculo vehiculoAuxiliar in e.vehiculos )
            {
                if(vehiculoAuxiliar == v)
                {
                    sonIguales = true;
                    break;
                }
            }

            return sonIguales;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string mensaje = "El vehículo no es parte del estacionamiento\n";

            foreach(Vehiculo auxVehiculo in estacionamiento.vehiculos)
            {
                if(auxVehiculo == vehiculo)
                {
                    mensaje = auxVehiculo.ImprimirTicket();
                    estacionamiento.vehiculos.Remove(auxVehiculo);
                    break;
                    
                }
            }

            return mensaje;

        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento != vehiculo && String.IsNullOrEmpty(vehiculo.Patente) == false)
            {
                if(estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }

            return estacionamiento;
        }

    }
}
