using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamentos
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamentos(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeículo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja adicionar: ");
            veiculos.Add(Console.ReadLine()); 

            Console.WriteLine(veiculos);
        }

        public void RemoverVeículo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas em que seu veículo ficou estacionado:");

                int horasEstacionado = 0;
                horasEstacionado = Convert.ToInt16(Console.ReadLine());

                decimal valorEstacionamento = precoInicial + precoPorHora * horasEstacionado;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o valor total do estacionamento foi {valorEstacionamento}");
            }
            else
            {
                Console.WriteLine("Desculpe esse veículo não consta em nosso sistema. Verifique se digitou a placa corretamente.");
            }
        }

        public void ListarVeículos()
        {  
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string carros in veiculos)
                {
                    Console.WriteLine(carros);
                } 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}