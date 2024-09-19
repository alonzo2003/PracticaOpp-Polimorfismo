using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOpp_Polimorfismo
{
    public class EmpleadoAdmin : Empleado
    {
        public decimal SalarioBase { get; set; }
        public bool MetaAlcanzada { get; set; }

        public EmpleadoAdmin(string nombre, decimal salarioBasa, bool metaAlcanzada)
            : base(nombre, "Empleado administrativo")
        {
            SalarioBase = salarioBasa;
            MetaAlcanzada = metaAlcanzada;
        }
        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
            throw new NotImplementedException();
        }
    }
}
