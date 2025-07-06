namespace OficinaVeiculos
{
    public enum StatusOrdemServico
    {
        Aberta,
        EmAndamento,
        Concluida,
        Cancelada
    }

    public class OrdemServico
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public StatusOrdemServico Status { get; private set; }
        public DateTime DataCriacao { get; }

        public OrdemServico(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
            Status = StatusOrdemServico.Aberta;
            DataCriacao = DateTime.Now;
        }

        public void AplicarDesconto(decimal percentual)
        {
            if (percentual < 0 || percentual > 100)
                throw new ArgumentOutOfRangeException(nameof(percentual));
            Valor -= Valor * (percentual / 100);
        }

        public void AlterarStatus(StatusOrdemServico novoStatus)
        {
            Status = novoStatus;
        }
    }
}
