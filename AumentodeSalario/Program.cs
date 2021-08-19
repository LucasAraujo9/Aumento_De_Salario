using System;
using System.Globalization;

namespace AumentodeSalario
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Novo salario: " + NovoSalarial(salario).ToString("F2", CultureInfo.InvariantCulture));
            var resultado = ReajusteGanho(salario);

            Console.WriteLine("Reajuste ganho: " + resultado.Item1.ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + resultado.Item2);

            Console.ReadLine();
        }

        public static double NovoSalarial(double salario)
        {
            if (salario > 0 && salario <= 400)
            {
                return salario *= 1.15;
            }
            else if (salario > 400 && salario <= 800)
            {
                return salario *= 1.12;
            }
            else if (salario > 800 && salario <= 1200)
            {
                return salario *= 1.10;
            }
            else if (salario > 1200 && salario <= 2000)
            {
                return salario *= 1.07;
            }
            else if (salario > 2000)
            {
                return salario *= 1.04;
            }

            return salario;
        }

        public static Tuple<double, string> ReajusteGanho(double salario)
        {
            var retorno = new Tuple<double, string>(0, "");

            if (salario <= 400)
            {
                retorno = new Tuple<double, string>(salario *= 0.15, "15%");
            }
            else if (salario > 400 && salario <= 800)
            {
                retorno = new Tuple<double, string>(salario *= 0.12, "1%");
            }
            else if (salario > 800 && salario <= 1200)
            {
                retorno = new Tuple<double, string>(salario *= 0.10, "10%");
            }
            else if (salario > 1200 && salario <= 2000)
            {
                retorno = new Tuple<double, string>(salario *= 0.07, "7%");
            }
            else if (salario > 2000)
            {
                retorno = new Tuple<double, string>(salario *= 0.04, "4%");
            }
            return retorno;
        }
    }
}
