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

        public double CalcularMensalidadeComDesconto(
            int valorBase,
            int mesesContratados)
        {
           switch (mesesContratados)
            {
                case mesesContratados >= 6 or mesesContratados <= 11:
                    valorBase = valorBase - (valorBase * 0,10);
                    break;
                case mesesContratados >= 12:
                    valorBase = valorBase - (valorBase *0,20);
                    break;
                default:
                    valorBase = valorBase;
                    break;
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