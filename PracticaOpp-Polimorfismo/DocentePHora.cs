using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOpp_Polimorfismo
{
     public class DocentePHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public decimal Tarifa { get; set; }

        public DocentePHora(string nombre, int horasTrabajadas) 
             : base (nombre, "Docente por hora")
        {
            HorasTrabajadas = horasTrabajadas;
            Tarifa = 800;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * Tarifa;
        }
    }
}
