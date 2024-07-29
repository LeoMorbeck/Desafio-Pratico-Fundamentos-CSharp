using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioPraticoRocket_1;
public class Exercicio5
{
    public void ValidarPlaca()
    {
        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine();

        string padrao = @"^[a-zA-Z]{3}\d{4}$";
        Regex regex = new Regex(padrao);

        if (regex.IsMatch(placa))
        {
            Console.WriteLine($"A {placa} é válida");
        }
        else
        {
            Console.WriteLine($"A {placa} é irregular");
        }
    }
}
