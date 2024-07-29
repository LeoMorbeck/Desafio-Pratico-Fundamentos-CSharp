using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRocket_1;
public class Exercicio4
{
    public void Contarcaracteres()
    {
        Console.Write("digite uma ou mais palavras: ");
        string frase = Console.ReadLine();

        Console.WriteLine(frase.Replace(" ", "").Count());
    }
}
