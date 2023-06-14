using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura2
{
    class Program
    {
        static void Main(string[] args)
        {

            float lanche1 = 8.00f;
            float salsicha1 = 1.50f;
            float hamburguer1 = 2.00f;
            float requeijao1 = 1.50f;
            float bacon1 = 2.00f;





            Console.WriteLine("Cardápio do Conradito Lanxes");
            Console.WriteLine("Valores");
            Console.WriteLine($"X-Tudo:hamburguer,bacon e salsicha - R$ {lanche1 + salsicha1 + hamburguer1 + bacon1}");
            Console.WriteLine($"Cachorro-quente cremoso: 2 salsichas e requeijao - R$ {lanche1 + salsicha1 + salsicha1 + requeijao1}");
            Console.WriteLine($"A moda da casa: salsicha, hamburguer, requeijao e bacon - R$ {salsicha1 + hamburguer1 + requeijao1 + bacon1}");
            Console.WriteLine("\n \n");
            Console.WriteLine($"COMBO: X-Tudo, Cachorro-Quente cremoso, A moda da casa - R$ {lanche1 + salsicha1 + hamburguer1 + bacon1 + lanche1 + salsicha1 + salsicha1 + requeijao1}");
















        }
    }
}
