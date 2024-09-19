using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace PracticaOpp_Polimorfismo
{
    public class DocenteContratoFijo : Empleado
    {
        public decimal SalarioBase {get;set;}
        public bool MetaAlcanzada {get;set;}

        public DocenteContratoFijo(string nombre, decimal salarioBase,bool metaAlcanzada)
            : base(nombre, "Docente de contrato fijo")
        {
            SalarioBase = salarioBase;
            MetaAlcanzada = metaAlcanzada;
        }
        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
