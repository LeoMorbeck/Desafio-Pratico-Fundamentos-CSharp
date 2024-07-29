using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRocket_1;
public class Exercicio3
{
    public void SomarValores()
    {
        double primeiroValor = 10;
        double SegundoValor = 4;

        Console.WriteLine(primeiroValor + SegundoValor);
        Console.WriteLine(primeiroValor - SegundoValor);
        Console.WriteLine(primeiroValor * SegundoValor);
        if (SegundoValor == 0)
        {
            Console.WriteLine("Não é possível dividir valor por zero");

        }
        else
        {
            Console.WriteLine(primeiroValor / SegundoValor);
        }
        Console.WriteLine((primeiroValor + SegundoValor) / 2);
    }
}
