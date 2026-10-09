using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreamingFlix.App;
using Xunit;

namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void Classificacao_DeveRetornarPlanoCorreto(
        int telas, string esperado)
    {
        var service = new PlanoStreamingService();

        var resultado = service.ObterClassificacaoPorQualidade(telas);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(50, 1, 50)]
    [InlineData(50, 6, 45)]
    [InlineData(50, 12, 40)]
    public void Desconto_DeveRetornarMensalidadeCorreta(
        int valorBase, int meses, int esperado)
    {
        var service = new PlanoStreamingService();

        var resultado = service.CalcularMensalidadeComDesconto(
            valorBase, meses);

        Assert.Equal((double)esperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(20, true, false)]
    [InlineData(16, false, false)]
    public void AcessoAdulto_DeveRetornarPermissaoCorreta(
        int idade, bool controleParentalAtivo, bool esperado)
    {
        var service = new PlanoStreamingService();

        var resultado = service.PodeAcessarConteudoAdulto(
            idade, controleParentalAtivo);

        Assert.Equal(esperado, resultado);
    }
}