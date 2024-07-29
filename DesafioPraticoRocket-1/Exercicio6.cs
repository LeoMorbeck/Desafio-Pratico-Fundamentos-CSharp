using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRocket_1;
public class Exercicio6
{
    public void FormatarDatas()
    {
        DateTime data = DateTime.Now;

        string formatoCompleto = data.ToString("dddd, dd MMMM yyyy HH: mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine(formatoCompleto);

        string formatoSimples = data.ToString("dd/MM/yyyy");
        Console.WriteLine(formatoSimples);

        string formatoHoras = data.ToString("HH:mm");
        Console.WriteLine(formatoHoras);

        string formatoExtenso = data.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine(formatoExtenso);
    }
}
