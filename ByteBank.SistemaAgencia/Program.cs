using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";


            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();



            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);
            //Console.ReadLine();



            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string moedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + moedaDestino);

            string moedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + moedaOrigem);

            Console.ReadLine();

        }
    }


}
