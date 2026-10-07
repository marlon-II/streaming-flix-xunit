# streaming-flix-xunit

### Visão geral:

É um sistema que realiza a gestão de contas de um streaming, nele se encontra as seguintes verificações:

* **Tipo de plano:**
Aqui o sistema consegue verificar o tipo do plano do cliente através da quantidade de telas simultâneas que o usuário tem.

* **Desconto:**
Dependendo de quantos meses o usuário contrata o serviço ele pode ganhar desconto e o sistema consegue calcular isso, dando 10% de desconto para quem contratou o serviço por 6 meses à 11 meses e 20 % para quem contratou 12 meses ou mais.

* **Acesso a conteúdo adulto:**
O sistema tem a capacidade de verificar se o usuário pode ter acesso a conteúdo adultos com base na sua idade.

---

### Requisitos Técnicos

Para garantir a correta execução da aplicação e das suítes de testes unitários, o ambiente de desenvolvimento deve atender aos seguintes requisitos técnicos:

* **Linguagem de Programação:** C#
* **Plataforma/Versão:** .NET SDK 10.0
* **Framework de Testes:** xUnit
* **Ferramentas de Linha de Comando (CLI):** .NET CLI (para compilação e execução dos testes)
* **Controle de Versão:** Git (para clonagem e gestão do repositório)

### Verificação do Ambiente
Para confirmar se a versão correta do .NET está instalada na sua máquina, execute o seguinte comando no terminal:
```bash
dotnet --version
```
---

### Como clonar o projeto:

Esse projeto é público no GitHub então basta realizar o comando **git clone** para ter o projeto em sua máquina, segue com o passa a passa:

* Crie uma pasta onde o projeto vai se encontrar;
* Abra a pasta pelo terminal;
* Dentro da pasta desejada rode o seguinte comando: ```git clone https://github.com/marlon-II/streaming-flix-xunit.git```
* Agora rode o seguinte comando para consegui realizar com alteração com o projeto ```cd streaming-flix-xunit```

---

### Rodar os testes unitários

Para rodar os teste unitários realize o seguinte passo a passo:

* Abra a pasta aonde se encontra o projeto pelo terminal;
* Rode o comando ```cd streaming-flix-xunit``` para ter certeza que está na pasta correta;
* Rode o comando ```dotnet test```
* Espere os testes terminarem;
* Pronto !

---

### Cobertura dos Testes Parametrizados

Os testes unitários foram implementados utilizando o framework **xUnit**, adotando a abordagem de testes parametrizados através das anotações `[Theory]` e `[InlineData]`. Essa técnica permite executar o mesmo método de teste múltiplas vezes com diferentes conjuntos de dados (Data-Driven Testing), garantindo uma maior cobertura de cenários sem a necessidade de duplicar o código.

Abaixo, apresentamos a explicação sumária da cobertura alcançada em cada regra de negócio:

* **Teste 1: Classificação de Planos (`ObterClassificacaoPorQualidade`)**
  A cobertura foca na validação das faixas de telas simultâneas. Foram testados os valores exatos de mudança de estado da regra de negócio: `1` tela (retornando BÁSICO), `2` telas (retornando PADRÃO) e `4` telas (retornando PREMIUM, validando a regra de "4 ou mais telas").

* **Teste 2: Cálculo de Descontos (`CalcularMensalidadeComDesconto`)**
  A cobertura assegura que o algoritmo de desconto seja aplicado corretamente de acordo com o tempo de contrato. Os testes garantem os cenários limítrofes: 
  * `1` mês (sem incidência de desconto).
  * `6` meses (garantindo a aplicação da primeira faixa de 10%).
  * `12` meses (garantindo a aplicação da faixa máxima de 20%).

* **Teste 3: Validação de Acesso a Conteúdo Adulto (`PodeAcessarConteudoAdulto`)**
  A cobertura valida a lógica condicional e a tabela-verdade da regra que exige duas condições simultâneas (idade >= 18 **E** controle parental inativo). Os testes contemplam:
  * O cenário positivo e ideal (maior de idade sem restrição -> `true`).
  * A restrição por configuração (maior de idade, mas com controle parental ativo -> `false`).
  * A restrição por idade (menor de idade -> `false`), garantindo que o acesso seja bloqueado independentemente da configuração.

---

#### Alunos

Marlon Andrade Bartoli
