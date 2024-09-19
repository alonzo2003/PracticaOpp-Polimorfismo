using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOpp_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            DocentePHora docentePorHora = new DocentePHora("Jese David", 31);
            Console.WriteLine($"Salario de {docentePorHora.Nombre}: {docentePorHora.CalcularSalario()}");

            EmpleadoAdmin empleadoAdministrativo = new EmpleadoAdmin("Winny Cristal", 7800, true);
            Console.WriteLine($"Salario de {empleadoAdministrativo.Nombre}: {empleadoAdministrativo.CalcularSalario()}");

            DocenteContratoFijo docenteContratoFijo = new DocenteContratoFijo("Camila Maria", 9700, false);
            Console.WriteLine($"Salario de {docenteContratoFijo.Nombre}: {docenteContratoFijo.CalcularSalario()}");

           
        }
    }

}
