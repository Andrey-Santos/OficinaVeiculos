using System;

namespace OficinaVeiculos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ordem = new OrdemServico("Troca de óleo", 150);
            Console.WriteLine($"Serviço: {ordem.Descricao}, Valor: R$ {ordem.Valor}");
        }
    }
}
