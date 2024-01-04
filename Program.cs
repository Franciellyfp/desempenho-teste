using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


    public class ProcessadorLoteBenchmark
    {
        [Params(2, 2, 2)] // Define o tamanho do lote a ser testado. O valor definido foi 2 que quer dizer que o lote vai ser executado 3x com o tamanho 2
        public int TamanhoDoLote;

        [Benchmark]
        public void ProcessarLote()
        {
        // cria uma instância  para processar o lote
        ProcessadorLote processador = new ProcessadorLote();
            processador.ProcessarLote();
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Executa os benchmarks
            var summary = BenchmarkRunner.Run<ProcessadorLoteBenchmark>();

            // Exibe os resultados
            Console.WriteLine(summary);
        }
    }

    class ProcessadorLote
    {
    // Função que realiza uma simulação de processamento para cada item em um loop de o a 9/
    public void ProcessarLote()
        {
            for (int i = 0; i < 10; i++)
            {
                // Retorna o valor * 2
                int resultado = OperacaoTesteDeDesempenho(i);

                // Imprimi resultados
                Console.WriteLine($"Item {i}: Resultado = {resultado}");
            }
        }

        // Função para simular uma operação de processamento
        private int OperacaoTesteDeDesempenho(int valor)
        {
          
            return valor * 2;
        }
    }
