using Framework.Interface;
using System;
using System.Linq;

namespace Framework.Help
{
    public class Help : IHelp
    {
        public string AlfanumericoAleatorio(int tamanho = 10)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
