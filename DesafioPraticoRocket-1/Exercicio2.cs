using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRocket_1;
public class Exercicio2
{
    public void Concatenar()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"{nome} {sobrenome}");
    }
}
