using Xunit;
using OficinaVeiculos;
using System;

namespace OficinaVeiculos.Tests
{
    public class OrdemServicoTests
    {
        [Fact]
        public void OrdemServico_DeveCriarComDescricaoEValor()
        {
            var ordem = new OrdemServico("Revisão", 200);
            Assert.Equal("Revisão", ordem.Descricao);
            Assert.Equal(200, ordem.Valor);
        }

        [Fact]
        public void OrdemServico_StatusInicialDeveSerAberta()
        {
            var ordem = new OrdemServico("Troca de óleo", 100);
            Assert.Equal(StatusOrdemServico.Aberta, ordem.Status);
        }

        [Fact]
        public void OrdemServico_DeveAlterarStatus()
        {
            var ordem = new OrdemServico("Troca de pneu", 150);
            ordem.AlterarStatus(StatusOrdemServico.Concluida);
            Assert.Equal(StatusOrdemServico.Concluida, ordem.Status);
        }

        [Fact]
        public void OrdemServico_DeveTerDataCriacaoProximaAgora()
        {
            var antes = DateTime.Now.AddSeconds(-1);
            var ordem = new OrdemServico("Alinhamento", 80);
            var depois = DateTime.Now.AddSeconds(1);
            Assert.InRange(ordem.DataCriacao, antes, depois);
        }

        [Fact]
        public void OrdemServico_DeveAplicarDescontoCorretamente()
        {
            var ordem = new OrdemServico("Balanceamento", 100);
            ordem.AplicarDesconto(10);
            Assert.Equal(90, ordem.Valor);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(150)]
        public void OrdemServico_AplicarDescontoInvalido_DeveLancarExcecao(decimal percentual)
        {
            var ordem = new OrdemServico("Freio", 200);
            Assert.Throws<ArgumentOutOfRangeException>(() => ordem.AplicarDesconto(percentual));
        }
    }
}
