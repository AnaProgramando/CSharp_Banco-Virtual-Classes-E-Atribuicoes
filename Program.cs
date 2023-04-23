using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAtribuicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco Virtual - Classes e Atribuições: \r\n");

            ContaCorrente contaFulano = new ContaCorrente();
            
            contaFulano.saldo = 100;           
            Console.WriteLine("O saldo da conta do Fulano é de R$ " + contaFulano.saldo + ".");
            
            contaFulano.saldo += 200.05;            
            Console.WriteLine("Foram adicionados R$ 200,05 a conta do Fulano. O saldo atual é de R$ " + contaFulano.saldo + ".");

            Console.WriteLine("____________________________________________________________________\r\n");

            ContaCorrente contaBeltrano = new ContaCorrente();
            contaBeltrano.saldo = 150;            
            Console.WriteLine("O saldo da conta do Beltrano é de R$ " + contaBeltrano.saldo + ".");

            contaBeltrano.saldo -= 99.08;
            Console.WriteLine("Foram retirados R$ 99,08 da conta do Beltrano. O saldo atual é de R$ " + contaBeltrano.saldo + ".");

            Console.ReadLine();
        }
    }
}
