using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TesteTecnicoTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
             Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
             Imprimir(SOMA);
             Ao final do processamento, qual será o valor da variável SOMA?*/

            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine($"Soma = {SOMA}");

            Console.WriteLine("#####################################################");

            /*Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
             * (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
             * informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem 
             * avisando se o número informado pertence ou não a sequência.*/

            Console.WriteLine("Informe um número para verificar se ele pertence a sequência de Fibonacci:");

            int numero = int.Parse(Console.ReadLine());
            int a = 0, b = 1, proximoNumero = 0;
            bool pertence = false;
            while (proximoNumero < numero)
            {
                proximoNumero = a + b; //atualizar o numero anterior
                a = b; //Atualiza atual
                b = proximoNumero; //Calcula proximo numero
                if (proximoNumero == numero)
                {
                    pertence = true;
                    break;
                }
            }
            if (pertence)
            {
                Console.WriteLine($"O número {numero} pertence a sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence a sequência de Fibonacci.");
            }
            Console.WriteLine("#############################################");

            /*Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
            • O menor valor de faturamento ocorrido em um dia do mês;
            • O maior valor de faturamento ocorrido em um dia do mês;
            • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

            IMPORTANTE:
            a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
            b) Podem existir dias sem faturamento, como nos finais de semana e feriados. 
            Estes dias devem ser ignorados no cálculo da média; */



            string json = File.ReadAllText(@"f:\dados.json");
            var faturamentoMensal = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json);

            // Filtrar dias com faturamento maior que zero
            var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

            if (diasComFaturamento.Count == 0)
            {
                Console.WriteLine("Não há dias com faturamento registrado.");
                return;
            }


            decimal menorValor = diasComFaturamento.Min(f => f.Valor);


            decimal maiorValor = diasComFaturamento.Max(f => f.Valor);


            decimal mediaMensal = diasComFaturamento.Average(f => f.Valor);


            int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

            // Exibir os resultados
            Console.WriteLine($"Menor valor de faturamento: {menorValor:C}");
            Console.WriteLine($"Maior valor de faturamento: {maiorValor:C}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");

            Console.WriteLine("############################################");

            /*Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
                • SP – R$67.836,43
                • RJ – R$36.678,66
                • MG – R$29.229,88
                • ES – R$27.165,48
                • Outros – R$19.849,53
                Escreva um programa onde calcule o percentual de representação que 
            cada estado teve dentro do valor total mensal da distribuidora.  */
            decimal faturamentoSP = 67836.43m;
            decimal faturamentoRJ = 36678.66m;
            decimal faturamentoMG = 29229.88m;
            decimal faturamentoES = 27165.48m;
            decimal faturamentoOutros = 19849.53m;

            decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
            decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
            decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
            decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
            decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

            Console.WriteLine($"Percentual de representação de SP: {percentualSP:F2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:F2}%");
            Console.WriteLine($"Percentual de representação de MG: {percentualMG:F2}%");
            Console.WriteLine($"Percentual de representação de ES: {percentualES:F2}%");
            Console.WriteLine($"Percentual de representação de Outros: {percentualOutros:F2}%");


            Console.WriteLine("################################");

            /*Escreva um programa que inverta os caracteres de um string.
            IMPORTANTE:
            a) Essa string pode ser informada através de qualquer entrada de sua preferência ou 
            pode ser previamente definida no código;
            b) Evite usar funções prontas, como, por exemplo, reverse;*/

            Console.WriteLine("Informe uma string para inverter:");
            string input = Console.ReadLine();

            // Usando StringBuilder para evitar a concatenação de strings
            StringBuilder reversedString = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            Console.WriteLine($"String invertida: {reversedString.ToString()}");


        }
    }



    class FaturamentoDiario
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }
        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }


}

