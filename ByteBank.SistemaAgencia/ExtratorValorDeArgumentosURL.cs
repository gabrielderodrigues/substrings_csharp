using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        /// <summary>
        /// Método que verifica se a url é nula ou vazia.
        /// </summary>
        /// <param name="url"></param>
        /// <exception cref="ArgumentException"></exception>
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url)) {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        /// <summary>
        /// Método que vai pegar o indexOf do parâmetro.
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <returns></returns>
        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado; 
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
