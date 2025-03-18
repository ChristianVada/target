using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Target
{
    public class Ex3
    {
        public void Resultado()
        {
            string jsonPath = Path.Combine(Directory.GetCurrentDirectory(),  "..", "..", "..", "faturamento.json");
            string json = File.ReadAllText(jsonPath);

            List<FaturamentoDiarioModel> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiarioModel>>(json);

            var diasComFaturamento = faturamento.Where(d => d.Valor > 0).ToList();

            if (diasComFaturamento.Count == 0)
            {
                Console.WriteLine("Não há dados de faturamento para processar.");
                return;
            }

            double menorFaturamento = diasComFaturamento.Min(d => d.Valor);
            double maiorFaturamento = diasComFaturamento.Max(d => d.Valor);

            double mediaMensal = diasComFaturamento.Average(d => d.Valor);

            int diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > mediaMensal);

            Console.WriteLine($"Menor faturamento do mês: R$ {menorFaturamento:F2}");
            Console.WriteLine($"Maior faturamento do mês: R$ {maiorFaturamento:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
    }
}
