using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaAviones.Models.Base;

namespace TareaAviones.Models
{
    public class Comercial : Avion
    {
        public Comercial(string piloto, string copiloto, string azafata, int capacidad, string lineaArea) : base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaArea = lineaArea;
        }
        public int Capacidad;
        public string LineaArea;
    }
}
