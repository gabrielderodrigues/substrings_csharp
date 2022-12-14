using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urlTeste = "https://www.bytebank.com/cambio";
            //int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            //Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio"));

            //Console.WriteLine(urlTeste.Contains("bytebank"));

            //string endereco = "R. São Carlos do Pinhal nº746";
            //string enderecoFormatado =
            //    endereco
            //        .ToUpper()
            //        .Replace("r.", "Rua")
            //        .Replace(" nº", ", Número ")
            //        .ToUpper();

            //Console.WriteLine(enderecoFormatado);

            //Console.ReadLine();

            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string textoDeTeste = "Meu nome é Gabriel, me ligue em 99871-5456";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);

            Console.ReadLine();

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


            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(termoBusca.ToUpper());

            //Console.WriteLine(mensagemOrigem.ToLower());

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.ReadLine();


            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string moedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + moedaDestino);

            string moedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + moedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();

        }
    }


}
