using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingFlix.App
{
    public class PlanoStreamingService
    {
        public string ObterClassificacaoPorQualidade(int telasSimultaneas)
        {

            switch (telasSimultaneas)
            {
                case 1:
                    return "BÁSICO";
                    break;
                case 2:
                    return "PADRÃO";
                    break;
                case 4:
                    return "PREMIUM";  
                    break;
                default:
                    return "INVÁLIDO";
                    break;
            }
        }

        public double CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
{
    if (mesesContratados >= 6 && mesesContratados <= 11)
    {
        return valorBase - (valorBase * 0.10);
    }
    else if (mesesContratados >= 12)
    {
        return valorBase - (valorBase * 0.20);
    }
    else
    {
        return valorBase;
    }
}


        public bool PodeAcessarConteudoAdulto(
            int idade,
            bool controleParentalAtivo)
        {
            if (idade < 18)
            {
                return controleParentalAtivo == true;
            }
            else
            {
                return controleParentalAtivo == false;
            }
        }
    }
}