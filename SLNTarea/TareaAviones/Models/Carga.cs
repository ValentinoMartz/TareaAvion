using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaAviones.Models.Base;

namespace TareaAviones.Models
{
    public class Carga : Avion
    {
        public Carga(string piloto, string copiloto, string azafata, double peso, string tipoMercaderia) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }
        public double Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" \nPeso: {Peso} toneladas \nTipo de Mercaderia: {TipoMercaderia}";
        }
    }
}
